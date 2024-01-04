
namespace GUI
{
    partial class Form1
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
            this.picBox_Introduction = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Introduction)).BeginInit();
            this.SuspendLayout();
            // 
            // picBox_Introduction
            // 
            this.picBox_Introduction.Location = new System.Drawing.Point(4, 2);
            this.picBox_Introduction.Name = "picBox_Introduction";
            this.picBox_Introduction.Size = new System.Drawing.Size(880, 676);
            this.picBox_Introduction.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_Introduction.TabIndex = 0;
            this.picBox_Introduction.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.Location = new System.Drawing.Point(718, 550);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 47);
            this.button1.TabIndex = 1;
            this.button1.Text = "Let\'s Start";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 681);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.picBox_Introduction);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Introduction)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox_Introduction;
        private System.Windows.Forms.Button button1;
    }
}

