using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace pkk111ilya
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            var a = (Button)sender;
            if (a.Text == ",")
            {
                if (textBox1.Text.IndexOf(",") == -1)
                {
                    textBox1.Text += a.Text;
                }

            }
            else
            {
                textBox1.Text += a.Text;
            }

          

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string x = textBox1.Text;
            if (x.Length == 2 && x[0]=='0' && x[1]!=',')
            {
                x = x.Substring(1, 1);
                textBox1.Text = x;
            }
            if (textBox1.Text.Length>16)
            {
                string txt = textBox1.Text;
                textBox1.Text = txt.Substring(0, 16);
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            string txt = textBox1.Text;
            textBox1.Text = txt.Substring(0, textBox1.Text.Length-1);
           if (textBox1.Text.Length < 1)
            {
                textBox1.Text = "0";
            }


        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button8_Click(object sender, EventArgs e)
        {//расчет обратного числа
            float x = float.Parse(textBox1.Text);
            if (x != 0)
            {
                x = 1 / x;
                textBox1.Text = x.ToString();
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {//возвидение в квадрат
            float x = float.Parse(textBox1.Text);
            x = x * x;
            textBox1.Text = x.ToString();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            float x = float.Parse(textBox1.Text);
            if (x != 0)
            {
                x *= -1;
                textBox1.Text = x.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textBox1.Text);
            if (x > 0)
            {
                x = Math.Sqrt(x);
                textBox1.Text = x.ToString();
            }
        }
    }
}
