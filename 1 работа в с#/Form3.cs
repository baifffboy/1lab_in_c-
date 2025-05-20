using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _1_работа_в_с_
{
    public partial class Form3 : Form
    {
        public static bool f3 = false; // Form1.I - обращаться так
        public static string s2 = null;

        public Form3()
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
                Form3.f3 = true;
                Form3.s2 = da;
                this.Close();
            }
            else
            {
                MessageBox.Show("Введите имя декана факультета!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
