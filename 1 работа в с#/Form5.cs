using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_работа_в_с_
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            string path = @"C:\Users\ilya_\OneDrive\Рабочий стол\си шарп\" + frm1.a() + ".txt";
            using (StreamWriter sw = new StreamWriter(new FileStream(path, FileMode.Append)))
            {
                sw.WriteLine("Факультет: " + frm1.z() + "Декан: " + frm1.x() + "Аббревиатура: " + frm1.c() + "______________________________________\r\n");
                sw.Close();
            }
            Application.Restart();
            Environment.Exit(0);
            Form1 frm = new Form1();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
            Form1 frm = new Form1();
            frm.Show();
        }
    }
}
