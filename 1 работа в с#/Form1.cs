using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _1_работа_в_с_
{
    public partial class Form1 : Form
    {
        public static string p1 = "";
        public static string p2 = "";
        public static string p3 = "";

        public string z()
        {
            return p1;
        }

        public string x()
        {
            return p2;
        }

        public string c()
        {
            return p3;
        }

        public Form1()
        {
            InitializeComponent();  
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
            if (p1 == "" && p2 == "" && p3 == "")
            {
                Form5 frm5 = new Form5();
                frm5.Show();
            }
            else
            {
                string path = @"C:\Users\ilya_\OneDrive\Рабочий стол\си шарп\" + a() + ".txt";
                using (StreamWriter sw = new StreamWriter(new FileStream(path, FileMode.Append)))
                {
                    sw.WriteLine("Факультет: " + p1 + "Декан: " + p2 + "Аббревиатура: " + p3 + "______________________________________\r\n");
                    sw.Close();
                }
                Application.Restart();
                Environment.Exit(0);
                Form1 frm1 = new Form1();
                frm1.Show();
            }
        }

        private void editWindowsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void facultyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        public void facultyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string buf = textBox5.Text;
            bool m = File.Exists(@"C:\Users\ilya_\OneDrive\Рабочий стол\си шарп\" + buf + ".txt");
            if (buf != "")
            {
                Form2 frm2 = new Form2();
                frm2.Show();
            }
            else
            {
                MessageBox.Show("Введите название файла в строку Output file name:!");
            }
        }

        public string a() { 
            return textBox5.Text;
        }

        private void deansNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string buf = textBox5.Text;
            bool m = File.Exists(@"C:\Users\ilya_\OneDrive\Рабочий стол\си шарп\" + buf + ".txt");
            if (buf != "")
            {
                Form3 frm3 = new Form3();
                frm3.Show();
            }
            else
            {
                MessageBox.Show("Введите название файла в строку Output file name:!");
            }
        }

        private void abbreviationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string buf = textBox5.Text;
            bool m = File.Exists(@"C:\Users\ilya_\OneDrive\Рабочий стол\си шарп\" + buf + ".txt");
            if (buf != "")
            {
                Form4 frm4 = new Form4();
                frm4.Show();
            }
            else
            {
                MessageBox.Show("Введите название файла в строку Output file name:!");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (Form2.f2)
            {
                textBox8.Text = Form2.s1;
                p1 = Form2.s1;
            }
            else 
            {
                checkBox1.Checked = false;
                MessageBox.Show("Введите изменения в окне Faculty");
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (Form3.f3)
            {
                textBox7.Text = Form3.s2;
                p2 = Form3.s2;
            }
            else
            {
                checkBox1.Checked = false;
                MessageBox.Show("Введите изменения в окне Dean's name");
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (Form4.f4)
            {
                textBox6.Text = Form4.s3;
                p3 = Form4.s3;
            }
            else
            {
                checkBox1.Checked = false;
                MessageBox.Show("Введите изменения в окне Abbreviation");
            }
        }
    }
}
