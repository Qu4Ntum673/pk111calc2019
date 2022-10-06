using System;
using System.Windows.Forms;

namespace pkk111ilya
{
    public partial class Form1 : Form
    {
        public double fnum;
        public double snum;
        public string deystvie = "";
        public bool clear = false;
        int counter = 0;
        public Form1()
        {
            InitializeComponent();
        }
        public double Sum(double _fnum,double _snum, string _deystvie)

        {
            double res;
            switch (_deystvie)
            {
                case "+":
                    res = _fnum + _snum;
                    break;
                case "-":
                    res = _fnum - _snum;
                    break;
                case "*":
                    res = _fnum * _snum;
                    break;
                case "/":
                    res = _fnum / _snum;
                    break;
                default:
                    res = double.NaN;
                    break;

            }
            return res;
        }
        private void button20_Click(object sender, EventArgs e)
        {
            if (clear)
            {
                textBox1.Clear();
                clear = false;
            }
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
            button7.Text = "X\u00B2";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string x = textBox1.Text;
            if (x.Length == 2 && x[0] == '0' && x[1] != ',')
            {
                x = x.Substring(1, 1);
                textBox1.Text = x;
            }




            if (textBox1.Text.Length > 16)
            {
                string txt = textBox1.Text;
                textBox1.Text = txt.Substring(0, 16);
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            string txt = textBox1.Text;
            textBox1.Text = txt.Substring(0, textBox1.Text.Length - 1);
            if (textBox1.Text.Length < 1)
            {
                textBox1.Text = "0";
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            float x = float.Parse(textBox1.Text);
            if (x != 0)
            {
                x = 1 / x;
                textBox1.Text = x.ToString();
            }






        }

        private void button7_Click(object sender, EventArgs e)
        {
            float x = float.Parse(textBox1.Text);
            x = x * x;
            textBox1.Text = x.ToString();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            float x = float.Parse(textBox1.Text);
            if (x != 0)
            {
                x *= -1;
                textBox1.Text = x.ToString();
            }




        }

        private void button6_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textBox1.Text);
            if (x > 0)
            {
                x = Math.Sqrt(x);
                textBox1.Text = x.ToString();
            }


        }

        private void button17_Click(object sender, EventArgs e)
        {// плюс
            counter++;
            if (counter == 1)
            {

            fnum = double.Parse(textBox1.Text);
            deystvie = "+";
            clear = true;
            textBox2.Text = fnum.ToString() + deystvie;
            }
            if (counter > 1)
            {
                snum = double.Parse(textBox1.Text);
                textBox1.Text = Sum(fnum, snum, deystvie).ToString();
                fnum = Sum(fnum, snum, deystvie);
                clear = true;
               
            }
            
        }

        private void button21_Click(object sender, EventArgs e)
        {// равно
            counter = 0;
            snum = double.Parse(textBox1.Text);
            double res;
           res= Sum(fnum,snum,deystvie);
            
            textBox1.Text =res.ToString();
            snum = double.NaN;
            fnum = double.NaN;
            deystvie = "";
            clear = true;


        }

        private void button13_Click(object sender, EventArgs e)
        {// минус
            fnum = double.Parse(textBox1.Text);
            deystvie = "-";
            clear = true;
            textBox2.Text = fnum.ToString() + deystvie;
            counter++;

        }

        private void button9_Click(object sender, EventArgs e)
        {// умножить
            fnum = double.Parse(textBox1.Text);
            deystvie = "*";
            clear = true;
            textBox2.Text = fnum.ToString() + deystvie;
            counter++;

        }

        private void button5_Click(object sender, EventArgs e)
        {// деление
            fnum = double.Parse(textBox1.Text);
            deystvie = "/";
            clear = true;
            textBox2.Text = fnum.ToString() + deystvie;
            counter++;

        }
    }
}


