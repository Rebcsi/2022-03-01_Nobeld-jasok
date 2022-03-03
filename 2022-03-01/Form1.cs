using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _2022_03_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //10.b
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Töltsön ki minden mezőt!");
                return;
            }
            //10.c 1989<  
          //  int.TryParse("", out int result);
            if (!int.TryParse(textBox1.Text, out int Év) || Év < 1989 )
            {
                MessageBox.Show("Hiba! Az évszám nem megfelelő!");
                return;
            }

            //10d
            StreamWriter sw = new StreamWriter("uj_dijazott.txt");
            sw.WriteLine("Év;Név;SzületésHalálozás;Országkód");
            sw.WriteLine(textBox1.Text + ";" + textBox2.Text + ";" + textBox3.Text + ";" + textBox4.Text + ";");
            sw.Close();

        }
    }
}
