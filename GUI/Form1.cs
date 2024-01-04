using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Bitmap Hinh_Introduction = new Bitmap(@"E:\Robot (tt)\Code\Introduction_Image.png");
            picBox_Introduction.Image = Hinh_Introduction;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 Control = new Form2();
            Control.Show();
        }
    }
}
