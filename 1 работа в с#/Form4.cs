using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_работа_в_с_
{
    public partial class Form4 : Form
    {
        public static bool f4 = false; // Form1.I - обращаться так
        public static string s3 = null;
        public Form4()
        {
            InitializeComponent();
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string da = textBox2.Text + "\r\n";
            if (da != "\r\n")
            {
                Form4.f4 = true;
                Form4.s3 = da;
                this.Close();
            }
            else
            {
                MessageBox.Show("Введите аббривеатуру факультета!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
