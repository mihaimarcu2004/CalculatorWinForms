using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Services;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        double a, b;
        int op;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string x = textBox1.Text;
            a = double.Parse(x);
            textBox1.Text = null;
            op = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string x = textBox1.Text;

            a = double.Parse(x);
            textBox1.Text = null;
            op = 2;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Console.WriteLine("=");
            string x = textBox1.Text;
            b = double.Parse(x);
            CalculatorServiceImp s=new CalculatorServiceImp();
            if(op==1)
            {
                double rez = s.Addition(a, b);
                textBox1.Text = rez.ToString();
            }
            if (op == 2)
            {
                double rez = s.Subtraction(a, b);
                textBox1.Text = rez.ToString();
            }
            if (op == 4)
            {
                double rez = s.Multiplication(a, b);
                textBox1.Text = rez.ToString();
            }
            if (op == 5)
            {
                double rez = s.Squared(a);
                textBox1.Text = rez.ToString();
            }
            if (op == 6)
            {
                double rez = s.Inv(a);
                textBox1.Text = rez.ToString();
            }
            if (op == 7)
            {
                double rez = s.Sqrt(a);
                textBox1.Text = rez.ToString();
            }
            if(op==8)
            {
                double rez = s.Module(a, b);
                textBox1.Text = rez.ToString();
            }
            if(op==9)
            {
                double rez = s.Division(a, b);
                textBox1.Text = rez.ToString();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += '7';
            Console.WriteLine(7);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            string x = textBox1.Text;
            a = double.Parse(x);
            textBox1.Text = null;
            op = 4;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += '9';
        }
        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += '8';
        }
        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += '4';
        }
        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += '5';
        }
        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += '6';
        }
        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += '1';
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += '2';
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += '3';
        }
        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += '0';
        }
        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text += '.';
        }
        private void button16_Click(object sender, EventArgs e)
        {
            string rez = textBox1.Text;
            string aj=null;
            if (rez[0] == '-')
            {
                for (int i = 1; i < rez.Length; ++i)
                    aj+=rez[i];
                rez = aj;
            }
            else
            {
                aj = rez;
                rez = "-";
                rez += aj;
            }
            textBox1.Text = rez;

        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            a = 0;
        }
        private void button18_Click(object sender, EventArgs e)
        {
            string x = textBox1.Text;
            a = double.Parse(x);
            op = 5;
        }
        private void button19_Click(object sender, EventArgs e)
        {
            string x = textBox1.Text;
            a = double.Parse(x);
            op = 6;
        }
        private void button20_Click(object sender, EventArgs e)
        {
            string x = textBox1.Text;
            a = double.Parse(x);
            op = 7;
        }
        private void button21_Click(object sender, EventArgs e)
        {
            string x = textBox1.Text;
            a = double.Parse(x);
            textBox1.Text = null;
            op = 8;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
        }
        private void button23_Click(object sender, EventArgs e)
        {
            string rez = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            textBox1.Text = rez;
        }

        private void button24_Click(object sender, EventArgs e)
        {
           
            string x = textBox1.Text;
            a = double.Parse(x);
            textBox1.Text = null;
            op = 9;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       

      
     

       

       

       

      
    }
}
