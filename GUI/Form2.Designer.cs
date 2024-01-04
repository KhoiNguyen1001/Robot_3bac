
namespace GUI
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.trackBar_theta1 = new System.Windows.Forms.TrackBar();
            this.trackBar_theta2 = new System.Windows.Forms.TrackBar();
            this.trackBar_theta3 = new System.Windows.Forms.TrackBar();
            this.lbl_theta1 = new System.Windows.Forms.Label();
            this.lbl_theta2 = new System.Windows.Forms.Label();
            this.lbl_theta3 = new System.Windows.Forms.Label();
            this.Input_Box_theta1 = new System.Windows.Forms.TextBox();
            this.Output_Px = new System.Windows.Forms.TextBox();
            this.lbl_Px = new System.Windows.Forms.Label();
            this.Input_Box_theta2 = new System.Windows.Forms.TextBox();
            this.Input_Box_theta3 = new System.Windows.Forms.TextBox();
            this.lbl_Py = new System.Windows.Forms.Label();
            this.lbl_Pz = new System.Windows.Forms.Label();
            this.Output_Py = new System.Windows.Forms.TextBox();
            this.Output_Pz = new System.Windows.Forms.TextBox();
            this.button_DHT = new System.Windows.Forms.Button();
            this.Input_Box_Px = new System.Windows.Forms.TextBox();
            this.Input_Box_Py = new System.Windows.Forms.TextBox();
            this.Input_Box_Pz = new System.Windows.Forms.TextBox();
            this.lbl_Px_DHN = new System.Windows.Forms.Label();
            this.lbl_Py_DHN = new System.Windows.Forms.Label();
            this.lbl_Pz_DHN = new System.Windows.Forms.Label();
            this.lbl_DHNghich = new System.Windows.Forms.Label();
            this.lbl_DHThuan = new System.Windows.Forms.Label();
            this.lbl_theta1_DHN = new System.Windows.Forms.Label();
            this.lbl_theta2_DHN = new System.Windows.Forms.Label();
            this.lbl_theta3_DHN = new System.Windows.Forms.Label();
            this.Output_theta1 = new System.Windows.Forms.TextBox();
            this.Output_theta2 = new System.Windows.Forms.TextBox();
            this.Output_theta3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_USBstatus = new System.Windows.Forms.Label();
            this.button_DHN = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.portsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.COM4_Selection = new System.Windows.Forms.ToolStripMenuItem();
            this.COM5_Selection = new System.Windows.Forms.ToolStripMenuItem();
            this.Button_Send = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_theta1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_theta2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_theta3)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // trackBar_theta1
            // 
            this.trackBar_theta1.LargeChange = 10;
            this.trackBar_theta1.Location = new System.Drawing.Point(78, 154);
            this.trackBar_theta1.Maximum = 360;
            this.trackBar_theta1.Minimum = -360;
            this.trackBar_theta1.Name = "trackBar_theta1";
            this.trackBar_theta1.Size = new System.Drawing.Size(375, 69);
            this.trackBar_theta1.TabIndex = 0;
            this.trackBar_theta1.Scroll += new System.EventHandler(this.trackBar_theta1_Scroll);
            // 
            // trackBar_theta2
            // 
            this.trackBar_theta2.LargeChange = 10;
            this.trackBar_theta2.Location = new System.Drawing.Point(78, 224);
            this.trackBar_theta2.Maximum = 360;
            this.trackBar_theta2.Minimum = -360;
            this.trackBar_theta2.Name = "trackBar_theta2";
            this.trackBar_theta2.Size = new System.Drawing.Size(375, 69);
            this.trackBar_theta2.TabIndex = 1;
            this.trackBar_theta2.Scroll += new System.EventHandler(this.trackBar_theta2_Scroll);
            // 
            // trackBar_theta3
            // 
            this.trackBar_theta3.LargeChange = 10;
            this.trackBar_theta3.Location = new System.Drawing.Point(78, 304);
            this.trackBar_theta3.Maximum = 360;
            this.trackBar_theta3.Minimum = -360;
            this.trackBar_theta3.Name = "trackBar_theta3";
            this.trackBar_theta3.Size = new System.Drawing.Size(375, 69);
            this.trackBar_theta3.TabIndex = 2;
            this.trackBar_theta3.Scroll += new System.EventHandler(this.trackBar_theta3_Scroll);
            // 
            // lbl_theta1
            // 
            this.lbl_theta1.AutoSize = true;
            this.lbl_theta1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_theta1.Location = new System.Drawing.Point(9, 154);
            this.lbl_theta1.Name = "lbl_theta1";
            this.lbl_theta1.Size = new System.Drawing.Size(78, 29);
            this.lbl_theta1.TabIndex = 3;
            this.lbl_theta1.Text = "theta1";
            // 
            // lbl_theta2
            // 
            this.lbl_theta2.AutoSize = true;
            this.lbl_theta2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_theta2.Location = new System.Drawing.Point(9, 228);
            this.lbl_theta2.Name = "lbl_theta2";
            this.lbl_theta2.Size = new System.Drawing.Size(78, 29);
            this.lbl_theta2.TabIndex = 4;
            this.lbl_theta2.Text = "theta2";
            // 
            // lbl_theta3
            // 
            this.lbl_theta3.AutoSize = true;
            this.lbl_theta3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_theta3.Location = new System.Drawing.Point(9, 307);
            this.lbl_theta3.Name = "lbl_theta3";
            this.lbl_theta3.Size = new System.Drawing.Size(78, 29);
            this.lbl_theta3.TabIndex = 5;
            this.lbl_theta3.Text = "theta3";
            // 
            // Input_Box_theta1
            // 
            this.Input_Box_theta1.Location = new System.Drawing.Point(459, 154);
            this.Input_Box_theta1.Name = "Input_Box_theta1";
            this.Input_Box_theta1.Size = new System.Drawing.Size(100, 26);
            this.Input_Box_theta1.TabIndex = 7;
            this.Input_Box_theta1.TextChanged += new System.EventHandler(this.Input_Box_theta1_TextChanged);
            // 
            // Output_Px
            // 
            this.Output_Px.Location = new System.Drawing.Point(663, 154);
            this.Output_Px.Name = "Output_Px";
            this.Output_Px.Size = new System.Drawing.Size(100, 26);
            this.Output_Px.TabIndex = 8;
            this.Output_Px.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_Px
            // 
            this.lbl_Px.AutoSize = true;
            this.lbl_Px.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_Px.Location = new System.Drawing.Point(608, 154);
            this.lbl_Px.Name = "lbl_Px";
            this.lbl_Px.Size = new System.Drawing.Size(40, 29);
            this.lbl_Px.TabIndex = 9;
            this.lbl_Px.Text = "Px";
            // 
            // Input_Box_theta2
            // 
            this.Input_Box_theta2.Location = new System.Drawing.Point(459, 231);
            this.Input_Box_theta2.Name = "Input_Box_theta2";
            this.Input_Box_theta2.Size = new System.Drawing.Size(100, 26);
            this.Input_Box_theta2.TabIndex = 10;
            this.Input_Box_theta2.TextChanged += new System.EventHandler(this.Input_Box_theta2_TextChanged);
            // 
            // Input_Box_theta3
            // 
            this.Input_Box_theta3.Location = new System.Drawing.Point(459, 304);
            this.Input_Box_theta3.Name = "Input_Box_theta3";
            this.Input_Box_theta3.Size = new System.Drawing.Size(100, 26);
            this.Input_Box_theta3.TabIndex = 11;
            this.Input_Box_theta3.TextChanged += new System.EventHandler(this.Input_Box_theta3_TextChanged);
            // 
            // lbl_Py
            // 
            this.lbl_Py.AutoSize = true;
            this.lbl_Py.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_Py.Location = new System.Drawing.Point(608, 229);
            this.lbl_Py.Name = "lbl_Py";
            this.lbl_Py.Size = new System.Drawing.Size(40, 29);
            this.lbl_Py.TabIndex = 12;
            this.lbl_Py.Text = "Py";
            // 
            // lbl_Pz
            // 
            this.lbl_Pz.AutoSize = true;
            this.lbl_Pz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_Pz.Location = new System.Drawing.Point(608, 304);
            this.lbl_Pz.Name = "lbl_Pz";
            this.lbl_Pz.Size = new System.Drawing.Size(40, 29);
            this.lbl_Pz.TabIndex = 13;
            this.lbl_Pz.Text = "Pz";
            // 
            // Output_Py
            // 
            this.Output_Py.Location = new System.Drawing.Point(663, 232);
            this.Output_Py.Name = "Output_Py";
            this.Output_Py.Size = new System.Drawing.Size(100, 26);
            this.Output_Py.TabIndex = 14;
            this.Output_Py.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Output_Pz
            // 
            this.Output_Pz.Location = new System.Drawing.Point(663, 304);
            this.Output_Pz.Name = "Output_Pz";
            this.Output_Pz.Size = new System.Drawing.Size(100, 26);
            this.Output_Pz.TabIndex = 15;
            this.Output_Pz.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_DHT
            // 
            this.button_DHT.BackColor = System.Drawing.Color.Lime;
            this.button_DHT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button_DHT.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_DHT.Location = new System.Drawing.Point(833, 215);
            this.button_DHT.Name = "button_DHT";
            this.button_DHT.Size = new System.Drawing.Size(211, 52);
            this.button_DHT.TabIndex = 16;
            this.button_DHT.Text = "Động học thuận";
            this.button_DHT.UseVisualStyleBackColor = false;
            this.button_DHT.Click += new System.EventHandler(this.button_DHT_Click);
            // 
            // Input_Box_Px
            // 
            this.Input_Box_Px.Location = new System.Drawing.Point(68, 427);
            this.Input_Box_Px.Name = "Input_Box_Px";
            this.Input_Box_Px.Size = new System.Drawing.Size(100, 26);
            this.Input_Box_Px.TabIndex = 17;
            // 
            // Input_Box_Py
            // 
            this.Input_Box_Py.Location = new System.Drawing.Point(68, 490);
            this.Input_Box_Py.Name = "Input_Box_Py";
            this.Input_Box_Py.Size = new System.Drawing.Size(100, 26);
            this.Input_Box_Py.TabIndex = 18;
            // 
            // Input_Box_Pz
            // 
            this.Input_Box_Pz.Location = new System.Drawing.Point(68, 549);
            this.Input_Box_Pz.Name = "Input_Box_Pz";
            this.Input_Box_Pz.Size = new System.Drawing.Size(100, 26);
            this.Input_Box_Pz.TabIndex = 19;
            // 
            // lbl_Px_DHN
            // 
            this.lbl_Px_DHN.AutoSize = true;
            this.lbl_Px_DHN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_Px_DHN.Location = new System.Drawing.Point(21, 426);
            this.lbl_Px_DHN.Name = "lbl_Px_DHN";
            this.lbl_Px_DHN.Size = new System.Drawing.Size(40, 29);
            this.lbl_Px_DHN.TabIndex = 20;
            this.lbl_Px_DHN.Text = "Px";
            // 
            // lbl_Py_DHN
            // 
            this.lbl_Py_DHN.AutoSize = true;
            this.lbl_Py_DHN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_Py_DHN.Location = new System.Drawing.Point(21, 486);
            this.lbl_Py_DHN.Name = "lbl_Py_DHN";
            this.lbl_Py_DHN.Size = new System.Drawing.Size(40, 29);
            this.lbl_Py_DHN.TabIndex = 21;
            this.lbl_Py_DHN.Text = "Py";
            // 
            // lbl_Pz_DHN
            // 
            this.lbl_Pz_DHN.AutoSize = true;
            this.lbl_Pz_DHN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_Pz_DHN.Location = new System.Drawing.Point(22, 545);
            this.lbl_Pz_DHN.Name = "lbl_Pz_DHN";
            this.lbl_Pz_DHN.Size = new System.Drawing.Size(40, 29);
            this.lbl_Pz_DHN.TabIndex = 22;
            this.lbl_Pz_DHN.Text = "Pz";
            // 
            // lbl_DHNghich
            // 
            this.lbl_DHNghich.AutoSize = true;
            this.lbl_DHNghich.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_DHNghich.ForeColor = System.Drawing.Color.Red;
            this.lbl_DHNghich.Location = new System.Drawing.Point(20, 376);
            this.lbl_DHNghich.Name = "lbl_DHNghich";
            this.lbl_DHNghich.Size = new System.Drawing.Size(236, 32);
            this.lbl_DHNghich.TabIndex = 23;
            this.lbl_DHNghich.Text = "Động học nghịch:";
            // 
            // lbl_DHThuan
            // 
            this.lbl_DHThuan.AutoSize = true;
            this.lbl_DHThuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_DHThuan.ForeColor = System.Drawing.Color.LimeGreen;
            this.lbl_DHThuan.Location = new System.Drawing.Point(19, 112);
            this.lbl_DHThuan.Name = "lbl_DHThuan";
            this.lbl_DHThuan.Size = new System.Drawing.Size(215, 32);
            this.lbl_DHThuan.TabIndex = 24;
            this.lbl_DHThuan.Text = "Động học thuận";
            // 
            // lbl_theta1_DHN
            // 
            this.lbl_theta1_DHN.AutoSize = true;
            this.lbl_theta1_DHN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_theta1_DHN.Location = new System.Drawing.Point(301, 426);
            this.lbl_theta1_DHN.Name = "lbl_theta1_DHN";
            this.lbl_theta1_DHN.Size = new System.Drawing.Size(143, 29);
            this.lbl_theta1_DHN.TabIndex = 25;
            this.lbl_theta1_DHN.Text = "theta1_DHN";
            // 
            // lbl_theta2_DHN
            // 
            this.lbl_theta2_DHN.AutoSize = true;
            this.lbl_theta2_DHN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_theta2_DHN.Location = new System.Drawing.Point(301, 490);
            this.lbl_theta2_DHN.Name = "lbl_theta2_DHN";
            this.lbl_theta2_DHN.Size = new System.Drawing.Size(143, 29);
            this.lbl_theta2_DHN.TabIndex = 26;
            this.lbl_theta2_DHN.Text = "theta2_DHN";
            // 
            // lbl_theta3_DHN
            // 
            this.lbl_theta3_DHN.AutoSize = true;
            this.lbl_theta3_DHN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_theta3_DHN.Location = new System.Drawing.Point(301, 549);
            this.lbl_theta3_DHN.Name = "lbl_theta3_DHN";
            this.lbl_theta3_DHN.Size = new System.Drawing.Size(143, 29);
            this.lbl_theta3_DHN.TabIndex = 27;
            this.lbl_theta3_DHN.Text = "theta3_DHN";
            // 
            // Output_theta1
            // 
            this.Output_theta1.Location = new System.Drawing.Point(459, 427);
            this.Output_theta1.Name = "Output_theta1";
            this.Output_theta1.Size = new System.Drawing.Size(100, 26);
            this.Output_theta1.TabIndex = 28;
            // 
            // Output_theta2
            // 
            this.Output_theta2.Location = new System.Drawing.Point(459, 490);
            this.Output_theta2.Name = "Output_theta2";
            this.Output_theta2.Size = new System.Drawing.Size(100, 26);
            this.Output_theta2.TabIndex = 29;
            // 
            // Output_theta3
            // 
            this.Output_theta3.Location = new System.Drawing.Point(459, 549);
            this.Output_theta3.Name = "Output_theta3";
            this.Output_theta3.Size = new System.Drawing.Size(100, 26);
            this.Output_theta3.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(9, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 32;
            this.label2.Text = "USB state:";
            // 
            // lbl_USBstatus
            // 
            this.lbl_USBstatus.AutoSize = true;
            this.lbl_USBstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_USBstatus.Location = new System.Drawing.Point(126, 59);
            this.lbl_USBstatus.Name = "lbl_USBstatus";
            this.lbl_USBstatus.Size = new System.Drawing.Size(108, 25);
            this.lbl_USBstatus.TabIndex = 33;
            this.lbl_USBstatus.Text = "Connected";
            // 
            // button_DHN
            // 
            this.button_DHN.BackColor = System.Drawing.Color.Red;
            this.button_DHN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button_DHN.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_DHN.Location = new System.Drawing.Point(833, 446);
            this.button_DHN.Name = "button_DHN";
            this.button_DHN.Size = new System.Drawing.Size(211, 58);
            this.button_DHN.TabIndex = 35;
            this.button_DHN.Text = "Động học nghịch";
            this.button_DHN.UseVisualStyleBackColor = false;
            this.button_DHN.Click += new System.EventHandler(this.button_DHN_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.portsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1066, 30);
            this.menuStrip1.TabIndex = 36;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // portsToolStripMenuItem
            // 
            this.portsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.COM4_Selection,
            this.COM5_Selection});
            this.portsToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.portsToolStripMenuItem.Name = "portsToolStripMenuItem";
            this.portsToolStripMenuItem.Size = new System.Drawing.Size(67, 26);
            this.portsToolStripMenuItem.Text = "Ports";
            // 
            // COM4_Selection
            // 
            this.COM4_Selection.Name = "COM4_Selection";
            this.COM4_Selection.Size = new System.Drawing.Size(164, 34);
            this.COM4_Selection.Text = "COM4";
            this.COM4_Selection.Click += new System.EventHandler(this.cOM4ToolStripMenuItem_Click);
            // 
            // COM5_Selection
            // 
            this.COM5_Selection.Name = "COM5_Selection";
            this.COM5_Selection.Size = new System.Drawing.Size(164, 34);
            this.COM5_Selection.Text = "COM5";
            this.COM5_Selection.Click += new System.EventHandler(this.cOM5ToolStripMenuItem_Click);
            // 
            // Button_Send
            // 
            this.Button_Send.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Button_Send.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Button_Send.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Button_Send.Location = new System.Drawing.Point(815, 59);
            this.Button_Send.Name = "Button_Send";
            this.Button_Send.Size = new System.Drawing.Size(229, 49);
            this.Button_Send.TabIndex = 37;
            this.Button_Send.Text = "Send data to Robot";
            this.Button_Send.UseVisualStyleBackColor = false;
            this.Button_Send.Click += new System.EventHandler(this.Button_Send_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 625);
            this.Controls.Add(this.Button_Send);
            this.Controls.Add(this.button_DHN);
            this.Controls.Add(this.lbl_USBstatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Output_theta3);
            this.Controls.Add(this.Output_theta2);
            this.Controls.Add(this.Output_theta1);
            this.Controls.Add(this.lbl_theta3_DHN);
            this.Controls.Add(this.lbl_theta2_DHN);
            this.Controls.Add(this.lbl_theta1_DHN);
            this.Controls.Add(this.lbl_DHThuan);
            this.Controls.Add(this.lbl_DHNghich);
            this.Controls.Add(this.lbl_Pz_DHN);
            this.Controls.Add(this.lbl_Py_DHN);
            this.Controls.Add(this.lbl_Px_DHN);
            this.Controls.Add(this.Input_Box_Pz);
            this.Controls.Add(this.Input_Box_Py);
            this.Controls.Add(this.Input_Box_Px);
            this.Controls.Add(this.button_DHT);
            this.Controls.Add(this.Output_Pz);
            this.Controls.Add(this.Output_Py);
            this.Controls.Add(this.lbl_Pz);
            this.Controls.Add(this.lbl_Py);
            this.Controls.Add(this.Input_Box_theta3);
            this.Controls.Add(this.Input_Box_theta2);
            this.Controls.Add(this.lbl_Px);
            this.Controls.Add(this.Output_Px);
            this.Controls.Add(this.Input_Box_theta1);
            this.Controls.Add(this.lbl_theta3);
            this.Controls.Add(this.lbl_theta2);
            this.Controls.Add(this.lbl_theta1);
            this.Controls.Add(this.trackBar_theta3);
            this.Controls.Add(this.trackBar_theta2);
            this.Controls.Add(this.trackBar_theta1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_theta1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_theta2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_theta3)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBar_theta1;
        private System.Windows.Forms.TrackBar trackBar_theta2;
        private System.Windows.Forms.TrackBar trackBar_theta3;
        private System.Windows.Forms.Label lbl_theta1;
        private System.Windows.Forms.Label lbl_theta2;
        private System.Windows.Forms.Label lbl_theta3;
        private System.Windows.Forms.TextBox Input_Box_theta1;
        private System.Windows.Forms.TextBox Output_Px;
        private System.Windows.Forms.Label lbl_Px;
        private System.Windows.Forms.TextBox Input_Box_theta2;
        private System.Windows.Forms.TextBox Input_Box_theta3;
        private System.Windows.Forms.Label lbl_Py;
        private System.Windows.Forms.Label lbl_Pz;
        private System.Windows.Forms.TextBox Output_Py;
        private System.Windows.Forms.TextBox Output_Pz;
        private System.Windows.Forms.Button button_DHT;
        private System.Windows.Forms.TextBox Input_Box_Px;
        private System.Windows.Forms.TextBox Input_Box_Py;
        private System.Windows.Forms.TextBox Input_Box_Pz;
        private System.Windows.Forms.Label lbl_Px_DHN;
        private System.Windows.Forms.Label lbl_Py_DHN;
        private System.Windows.Forms.Label lbl_Pz_DHN;
        private System.Windows.Forms.Label lbl_DHNghich;
        private System.Windows.Forms.Label lbl_DHThuan;
        private System.Windows.Forms.Label lbl_theta1_DHN;
        private System.Windows.Forms.Label lbl_theta2_DHN;
        private System.Windows.Forms.Label lbl_theta3_DHN;
        private System.Windows.Forms.TextBox Output_theta1;
        private System.Windows.Forms.TextBox Output_theta2;
        private System.Windows.Forms.TextBox Output_theta3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_USBstatus;
        private System.Windows.Forms.Button button_DHN;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem portsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem COM4_Selection;
        private System.Windows.Forms.ToolStripMenuItem COM5_Selection;
        private System.Windows.Forms.Button Button_Send;
    }
}