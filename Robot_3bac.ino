#define PWM_Base   9
#define PWM_Khau1  10
#define PWM_Khau2  11

#define Dir_Base   4
#define Dir_Khau1  5
#define Dir_Khau2  6

#define ENC_IN0    8
#define ENC_IN1    2
#define ENC_IN2    3

#define STOP_BT    7
volatile bool STOP_Base=1,STOP_Khau1=1,STOP_Khau2=1;

//int SensorHall = A0;
//volatile int Pulse_Hall = 0;

float kp[3] = {0.50, 0.50, 0.70};
float ki[3] = {0.05, 0.00, 0.05};
float kd[3] = {0.30, 0.40, 0.40};

uint16_t PWM_Val[3] = {0, 0, 0};
uint8_t DIR_Val[3] = {0, 0, 0};
float E_percentage[3] = {0, 0, 0};
float E_intergral[3]  = {0, 0, 0};
float dedt[3]         = {0, 0, 0};
int E[3]     = {0, 0, 0};
int E_pre[3] = {0, 0, 0};

long preT = 0 , currT = 0;
float deltaT = 0;

String inputString = "";
volatile int data_input[3];
bool stringComplete = false;
int i=0;

int theta1=0       ,theta2=0       ,theta3=0;
int theta1_now=0   ,theta2_now=0   ,theta3_now;
int theta1_adjust=0,theta2_adjust=0,theta3_adjust=0;

volatile int Pulse_Base = 0, Pulse_Khau1 = 0, Pulse_Khau2 = 0;
int Pulse_REF_Base=0,Pulse_REF_Khau1=0,Pulse_REF_Khau2=0;
int Pulse_offset[3] = {0 ,0 ,0};

void setup()
{
  Serial.begin(9600); 
  inputString.reserve(200);
  
  pinMode(STOP_BT, INPUT_PULLUP);
  //pinMode(SensorHall, INPUT_PULLUP);

  pinMode(ENC_IN0, INPUT_PULLUP);
  pinMode(ENC_IN1, INPUT_PULLUP);
  pinMode(ENC_IN2, INPUT_PULLUP);

  pinMode(PWM_Base , OUTPUT);
  pinMode(PWM_Khau1, OUTPUT);
  pinMode(PWM_Khau1, OUTPUT);
  
  pinMode(Dir_Base , OUTPUT);
  pinMode(Dir_Khau1, OUTPUT);
  pinMode(Dir_Khau2, OUTPUT);
  
  /*
  Port B 0001
  Port C 0010
  Port D 0100
  */
  //PCICR |= B00000010;
  //PCMSK1 |= B00000001;

  PCICR |= B00000001;   // Enable PCIE0 Bit0 = 1 (Port B)
  PCMSK0 |= B00000001;  // Select PCINT0 Bit0 = 1 (Pin 8_PB0)

  attachInterrupt(digitalPinToInterrupt(ENC_IN1),enc_interrupt_1,FALLING);
  attachInterrupt(digitalPinToInterrupt(ENC_IN2),enc_interrupt_2,FALLING); 
}

void loop() 
{
  /*
  TINH TOAN XUNG CHO DE ROBOT
  Hop so cua de la 270:1
  Vay de quay 1 vong sau HOP SO  la: 11*270=2970 xung
  Ti so truyen giua Puly 60 va Puly 20 la: 3:1
  Vay het 1 vong cho truc chinh la: 2970*3=8910 xung

  TINH TOAN XUNG CHO KHAU 1 va 2
  Hop so cua de la 168:1
  Vay de quay 1 vong sau HOP SO  la: 11*168=1848 xung
  Ti so truyen giua Puly 60 va Puly 20 la: 3:1
  Vay het 1 vong cho truc chinh la: 1848*3=5544 xung
  */
  if(digitalRead(STOP_BT)==LOW)
  {
    STOP_Base  = 1;
    STOP_Khau1 = 1;
    STOP_Khau2 = 1;
    Pulse_REF_Base = 0;
    Pulse_REF_Khau1 = 0;
    Pulse_REF_Khau2 = 0;
  }

  if(STOP_Base==1)
  { 
    analogWrite(PWM_Base,0);
    digitalWrite(Dir_Base, LOW);
    theta1_now=theta1;
  }
  if(STOP_Khau1==1)
  {
    analogWrite(PWM_Khau1,0);
    digitalWrite(Dir_Khau1, LOW);
    theta2_now=theta2;
  }
  if(STOP_Khau2==1)
  {
    analogWrite(PWM_Khau2,0);
    digitalWrite(Dir_Khau2, LOW);
    theta3_now=theta3;
  }

  float u[3] = {0, 0, 0};
 
  currT = micros();
  deltaT = ((float) (currT - preT))/(1.0e3);
  E[0] = Pulse_REF_Base - Pulse_Base;
  E[1] = Pulse_REF_Khau1 - Pulse_Khau1;
  E[2] = Pulse_REF_Khau2 - Pulse_Khau2;
  E_percentage[0] = ((double) Pulse_Base) / Pulse_REF_Base;
  E_percentage[1] = ((double) Pulse_Khau1)/ Pulse_REF_Khau1;
  E_percentage[2] = ((double) Pulse_Khau2)/ Pulse_REF_Khau2;

  if(deltaT >= 1000)
  {
    for (int j = 0; j < 3; j++)
    {
      E_intergral[j] = (E_intergral[j] + ((float) E[j])*deltaT) * (E_percentage[j] >= 0.65);
      dedt[j] = (E_pre[j] - E[j])/deltaT;
      preT = currT;
      E_pre[j] = E[j];
    }
  }

  for (int j =0; j < 3; j++)
  {
    u[j] = kp[j] * E[j] * (E[j] > 0) - ki[j] * E_intergral[j] * (E_percentage[j] < 0.71) - kd[j] * dedt[j] * (E_percentage[j] > 0.7) * (E[j] > 0);
    PWM_Val[j] = (int) fabs(u[j]);
    if(PWM_Val[j] > 255) PWM_Val[j] = 255;
    if(DIR_Val[j] == 1)  PWM_Val[j] = 255 - PWM_Val[j];
  }

  if(STOP_Base==0)
  {
    analogWrite(PWM_Base,  PWM_Val[0]);
    digitalWrite(Dir_Base, DIR_Val[0]);
  }
  if(STOP_Khau1==0)
  {
    analogWrite(PWM_Khau1, PWM_Val[1]);
    digitalWrite(Dir_Khau1,DIR_Val[1]);
  }
  if(STOP_Khau2==0)
  {
    analogWrite(PWM_Khau2, PWM_Val[2]);
    digitalWrite(Dir_Khau2,DIR_Val[2]);
  }
  
  if (stringComplete)
  {
    stringComplete = false;
    theta1_now = theta1;
    theta2_now = theta2;
    theta3_now = theta3;   

    theta1=data_input[0];
    theta2=data_input[1];
    theta3=data_input[2];
    if(theta1 > 170)  theta1 = theta1 - 360;
    if(theta2 > 200)  theta2 = theta2 - 360;
    if(theta3 > 170)  theta3 = theta3 - 360;
    Pulse_offset[0] = Pulse_Base - Pulse_REF_Base;
    Pulse_offset[1] = Pulse_Khau1 - Pulse_REF_Khau1;
    Pulse_offset[2] = Pulse_Khau2 - Pulse_REF_Khau2;
    Pulse_REF_Base = 0;
    Pulse_REF_Khau1 = 0;
    Pulse_REF_Khau2 = 0;
    Pulse_Base = 0;
    Pulse_Khau1 = 0;
    Pulse_Khau2 = 0;

    if(theta1!=theta1_now)
    {
      theta1_adjust = theta1 - theta1_now;
      STOP_Base = 0;
      if(theta1_adjust>0)
      {
        Pulse_REF_Base = (theta1 - theta1_now)*24.75 - Pulse_offset[0];
        DIR_Val[0]=0;
      }
      if(theta1_adjust<0)
      {
        Pulse_REF_Base = abs(theta1_now-theta1)*24.75 - Pulse_offset[0];
        DIR_Val[0]=1;
      }
    }

    if(theta2!=theta2_now)
    {
      theta2_adjust=theta2-theta2_now;
      STOP_Khau1=0;
      if(theta2_adjust>0)
      {
        Pulse_REF_Khau1 = (theta2 - theta2_now)*15.4 - Pulse_offset[1];
        DIR_Val[1]=0;
      }
      if(theta2_adjust<0)
      {
        Pulse_REF_Khau1 = abs(theta2_now-theta2)*15.4 - Pulse_offset[1];
        DIR_Val[1]=1;
      }
    }

    if(theta3!=theta3_now)
    {
      theta3_adjust=theta3-theta3_now;
      STOP_Khau2=0;
      if(theta3_adjust>0)
      {
        Pulse_REF_Khau2=(theta3-theta3_now)*15.4 - Pulse_offset[2];
        DIR_Val[2]=0;
      }
      if(theta3_adjust<0)
      {
        Pulse_REF_Khau2 = abs(theta3_now-theta3)*15.4 - Pulse_offset[2];
        DIR_Val[2]=1;
      }
    }

    Serial.print("Nhan du lieu vao:");
    Serial.print(theta1);   Serial.print("\t");   Serial.print(theta1_now);   Serial.print("\t");   Serial.println(Pulse_REF_Base);
    Serial.print(theta2);   Serial.print("\t");   Serial.print(theta2_now);   Serial.print("\t");   Serial.println(Pulse_REF_Khau1);
    Serial.print(theta3);   Serial.print("\t");   Serial.print(theta3_now);   Serial.print("\t");   Serial.println(Pulse_REF_Khau2);
  }
}

//Chương trình ngắt đếm xung cho đế Robot
ISR (PCINT0_vect)
{
  if(digitalRead(ENC_IN0) == LOW)
  {
    Pulse_Base++;
    if(Pulse_Base>=Pulse_REF_Base) STOP_Base=1;
  }
}

//Chương trình ngắt đếm xung cho Khâu 1
void enc_interrupt_1()
{
  Pulse_Khau1++;
  if(Pulse_Khau1>=Pulse_REF_Khau1) STOP_Khau1=1;
}

void enc_interrupt_2()
{
  Pulse_Khau2++;
  if(Pulse_Khau2>=Pulse_REF_Khau2) STOP_Khau2=1;
}

// Chương trình ngắt sự kiện Serial
void serialEvent()
{
  while (Serial.available())
  {
    int inChar = Serial.read();
    if (isDigit(inChar))  inputString += (char)inChar;
    if (inChar == '\n')
    {
      data_input[i] =inputString.toInt();
      inputString= "";
      i++;
      if(i==3)
      {
        i=0;
        stringComplete=true;
      }
    }
  }
}