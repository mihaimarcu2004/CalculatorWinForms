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
        int op=0;
        int lastop = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (op != 0)
            {
                button3.PerformClick();
            }

            string x = textBox1.Text;
            try
            {
                a = double.Parse(x);
              
                textBox2.Text = textBox1.Text + "+";
                
                textBox1.Text = null;
                op = 1;
            }
            catch
            {
                MessageBox.Show("Nu e text");
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (op != 0)
            {
                button3.PerformClick();
            }
            string x = textBox1.Text;
            try
            {
                textBox2.Text = textBox1.Text + "-";
                a = double.Parse(x);
                textBox1.Text = null;
                op = 2;
            }
            catch
            {
                MessageBox.Show("Nu e text");
            }
            
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Console.WriteLine("=");
            string x = textBox1.Text;
            try
            {
                b = double.Parse(x);
                lastop = 1;
                CalculatorServiceImp s = new CalculatorServiceImp();
                if (op == 1)
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
                if (op == 8)
                {
                    double rez = s.Module(a, b);
                    textBox1.Text = rez.ToString();
                }
                if (op == 9)
                {
                    double rez = s.Division(a, b);
                    textBox1.Text = rez.ToString();
                }
                if(op==1 || op==2 || op==4 || op==8 || op==9)
                {
                    textBox2.Text += b + "=";
                    textBox2.Text += textBox1.Text;
                }
                else
                {
                    textBox2.Text += "="+textBox1.Text;
                }
                op = 0;
            }
            catch
            {
                MessageBox.Show("Nu e text");
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(lastop==1)
            {
                lastop = 0;
                textBox1.Text = null;
            }
            textBox1.Text += '7';
            Console.WriteLine(7);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if(op!=0)
            {
                button3.PerformClick();
            }
            string x = textBox1.Text;
            try
            {
                a = double.Parse(x);
                textBox2.Text = textBox1.Text + "*";
                textBox1.Text = null;
                op = 4;
            }
            catch
            {
                MessageBox.Show("Nu e text");
            }
            
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (lastop == 1)
            {
                lastop = 0;
                textBox1.Text = null;
            }
            textBox1.Text += '9';
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (lastop == 1)
            {
                lastop = 0;
                textBox1.Text = null;
            }
            textBox1.Text += '8';
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (lastop == 1)
            {
                lastop = 0;
                textBox1.Text = null;
            }
            textBox1.Text += '4';
        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (lastop == 1)
            {
                lastop = 0;
                textBox1.Text = null;
            }
            textBox1.Text += '5';
        }
        private void button10_Click(object sender, EventArgs e)
        {
            if (lastop == 1)
            {
                lastop = 0;
                textBox1.Text = null;
            }
            textBox1.Text += '6';
        }
        private void button11_Click(object sender, EventArgs e)
        {
            if (lastop == 1)
            {
                lastop = 0;
                textBox1.Text = null;
            }
            textBox1.Text += '1';
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (lastop == 1)
            {
                lastop = 0;
                textBox1.Text = null;
            }
            textBox1.Text += '2';
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (lastop == 1)
            {
                lastop = 0;
                textBox1.Text = null;
            }
            textBox1.Text += '3';
        }
        private void button14_Click(object sender, EventArgs e)
        {
            if (lastop == 1)
            {
                lastop = 0;
                textBox1.Text = null;
            }
            textBox1.Text += '0';
        }
        private void button15_Click(object sender, EventArgs e)
        {
            if (lastop == 1)
            {
                lastop = 0;
                textBox1.Text = null;
            }
            textBox1.Text += '.';
        }
        private void button16_Click(object sender, EventArgs e)
        {
            string rez = textBox1.Text;
            string aj=null;
            if (rez.Length>0 && rez[0] == '-')
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
            lastop = 0;

        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
            a = 0;
        }
        private void button18_Click(object sender, EventArgs e)
        {
            if (op != 0)
            {
                button3.PerformClick();
            }
            string x = textBox1.Text;
            try
            {
                a = double.Parse(x);
                textBox2.Text = textBox1.Text + "^2";
                op = 5;
            }
            catch
            {
                MessageBox.Show("Nu e text");
            }
            
        }
        private void button19_Click(object sender, EventArgs e)
        {
            if (op != 0)
            {
                button3.PerformClick();
            }
            string x = textBox1.Text;
            try
            {
                a = double.Parse(x);
                textBox2.Text= "1/" +textBox1.Text;
                op = 6;
            }
            catch
            {
                MessageBox.Show("Nu e text");
            }
        }
        private void button20_Click(object sender, EventArgs e)
        {
            if (op != 0)
            {
                button3.PerformClick();
            }
            string x = textBox1.Text;
            try
            {
                a = double.Parse(x);
                textBox2.Text = "sqrt( "+textBox1.Text + " )";
                op = 7;
            }
            catch
            {
                MessageBox.Show("Nu e text");
            }
            
        }
        private void button21_Click(object sender, EventArgs e)
        {
            if (op != 0)
            {
                button3.PerformClick();
            }
            string x = textBox1.Text;
            try
            {
                a = double.Parse(x);
                textBox2.Text = textBox1.Text + "%";
                textBox1.Text = null;
                
                op = 8;
            }
            catch
            {
                MessageBox.Show("Nu e text");
            }
            
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
            if (op != 0)
            {
                button3.PerformClick();
            }
            string x = textBox1.Text;
            try
            {
                a = double.Parse(x);
                textBox2.Text = textBox1.Text + "/";
                textBox1.Text = null;
                op = 9;
            }
            catch
            {
                MessageBox.Show("Nu e text");
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       

      
     

       

       

       

      
    }
}
