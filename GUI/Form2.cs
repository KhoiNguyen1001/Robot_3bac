using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form2 : Form
    {
        SerialPort serialPort;
        string Input_theta1, Input_theta2, Input_theta3, Data_sent;

        Double L1 = 114.55, L2 = 158.5, L3 = 100;
        Double d1 = 164.55;
        public Form2()
        {
            InitializeComponent();
            serialPort = new SerialPort("COM5", 9600);
            COM5_Selection.Checked = true;
            try
            {
                serialPort.Open();
                lbl_USBstatus.ForeColor = System.Drawing.Color.Green;
                lbl_USBstatus.Text = "Conected - COM5";
            }
            catch
            {
                Console.WriteLine("Unable to open COM port - check it's not in use. \n");
                lbl_USBstatus.ForeColor = System.Drawing.Color.Red;
                lbl_USBstatus.Text = "No COM detected";
            }
        }

        // Động học thuận
        void DongHocThuan()
        {
            double Theta1_DHT = double.Parse(Input_Box_theta1.Text) * Math.PI / 180;
            double Theta2_DHT = double.Parse(Input_Box_theta2.Text) * Math.PI / 180;
            double Theta3_DHT = double.Parse(Input_Box_theta3.Text) * Math.PI / 180;

            double Px_DHT = (L1 + L2 * Math.Cos(Theta2_DHT) + L3 * Math.Cos(Theta2_DHT + Theta3_DHT)) * Math.Cos(Theta1_DHT);
            double Py_DHT = (L1 + L2 * Math.Cos(Theta2_DHT) + L3 * Math.Cos(Theta2_DHT + Theta3_DHT)) * Math.Sin(Theta1_DHT);
            double Pz_DHT = L2 * Math.Sin(Theta2_DHT) + L3 * Math.Sin(Theta2_DHT + Theta3_DHT) + d1;

            Output_Px.Text = Px_DHT.ToString();
            Output_Py.Text = Py_DHT.ToString();
            Output_Pz.Text = Pz_DHT.ToString();
        }

        private void button_DHT_Click(object sender, EventArgs e)
        {
            trackBar_theta1.Value = (int) float.Parse(Input_Box_theta1.Text);
            trackBar_theta2.Value = (int) float.Parse(Input_Box_theta2.Text);
            trackBar_theta3.Value = (int) float.Parse(Input_Box_theta3.Text);
            DongHocThuan();
        }


        // Động học nghịch
        void DongHocNghich()
        {
            double Px = double.Parse(Input_Box_Px.Text);
            double Py = double.Parse(Input_Box_Py.Text);
            double Pz = double.Parse(Input_Box_Pz.Text);

            // tính Theta1
            double theta1 = Math.Atan2(Py, Px);

            // Tính theta3
            double n1_t3 = Px * Math.Cos(theta1) - L1 + Py * Math.Sin(theta1);
            double n2_t3 = Pz - d1;

            double c3 = -(L3 * L3 + L2 * L2 - Math.Pow(n1_t3, 2) - Math.Pow(n2_t3, 2)) / (2 * L2 * L3);
            double s3 = Math.Sqrt(1 - Math.Pow(c3, 2));
            double theta3 = - Math.Atan2(s3, c3);

            // Tính theta2
            double c2 = (n1_t3 * (L3 * Math.Cos(theta3) + L2) + L3 * Math.Sin(theta3) * n2_t3) / (Math.Pow(L3 * Math.Cos(theta3) + L2, 2) + Math.Pow(L3 * Math.Sin(theta3), 2));
            double s2 = (n2_t3 * (L3 * Math.Cos(theta3) + L2) - L3 * Math.Sin(theta3) * n1_t3) / (Math.Pow(L3 * Math.Cos(theta3) + L2, 2) + Math.Pow(L3 * Math.Sin(theta3), 2));
            double theta2 = Math.Atan2(s2, c2);

            // Convert Radian to Degree và cho hiển thị ra textbox
            Output_theta1.Text = (theta1 * 180 / Math.PI).ToString();
            Output_theta2.Text = (theta2 * 180 / Math.PI).ToString();
            Output_theta3.Text = (theta3 * 180 / Math.PI).ToString();

            //Output_theta2.Text = c3.ToString();
            //Output_theta3.Text = s3.ToString();
        }
        private void button_DHN_Click(object sender, EventArgs e)
        {
            DongHocNghich();
        }


        //Dieu khien theta1
        private void Input_Box_theta1_TextChanged(object sender, EventArgs e)
        {
            Input_theta1 = Input_Box_theta1.Text;
        }
        private void trackBar_theta1_Scroll(object sender, EventArgs e)
        {
            Input_Box_theta1.Text = trackBar_theta1.Value.ToString();
        }


        //Dieu khien theta2
        private void Input_Box_theta2_TextChanged(object sender, EventArgs e)
        {
            Input_theta2 = Input_Box_theta2.Text;
        }
        private void trackBar_theta2_Scroll(object sender, EventArgs e)
        {
            Input_Box_theta2.Text = trackBar_theta2.Value.ToString();
        }


        // Dieu khien theta3
        private void Input_Box_theta3_TextChanged(object sender, EventArgs e)
        {
            Input_theta3 = Input_Box_theta3.Text;
        }

        private void trackBar_theta3_Scroll(object sender, EventArgs e)
        {
            Input_Box_theta3.Text = trackBar_theta3.Value.ToString();
        }


        // Gửi dữ liệu
        private void Button_Send_Click(object sender, EventArgs e)
        {
            if (int.Parse(Input_theta1) < 0) Input_theta1 = (int.Parse(Input_theta1) + 360).ToString();
            if (int.Parse(Input_theta2) < 0) Input_theta2 = (int.Parse(Input_theta2) + 360).ToString();
            if (int.Parse(Input_theta3) < 0) Input_theta3 = (int.Parse(Input_theta3) + 360).ToString();
            if (serialPort.IsOpen)
            {
                Data_sent = Input_theta1 + '\n' + Input_theta2 + '\n' + Input_theta3 + '\n';
                serialPort.Write(Data_sent);
                lbl_USBstatus.Text = Data_sent;
            }
        }


        // Chọn cổng COM
        private void cOM4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            COM4_Selection.Checked = true;
            COM5_Selection.Checked = false;
            serialPort = new SerialPort("COM4", 9600);
            try
            {
                serialPort.Open();
                lbl_USBstatus.ForeColor = System.Drawing.Color.Green;
                lbl_USBstatus.Text = "Connected - COM4";
            }
            catch
            {
                lbl_USBstatus.ForeColor = System.Drawing.Color.Red;
                lbl_USBstatus.Text = "No COM detected";
            }
        }

        private void cOM5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            COM5_Selection.Checked = true;
            COM4_Selection.Checked = false;
            serialPort = new SerialPort("COM5", 9600);
            try
            {
                serialPort.Open();
                lbl_USBstatus.ForeColor = System.Drawing.Color.Green;
                lbl_USBstatus.Text = "Connected - COM5";
            }
            catch
            {
                lbl_USBstatus.ForeColor = System.Drawing.Color.Red;
                lbl_USBstatus.Text = "No COM detected";
            }
        }
    }
}
