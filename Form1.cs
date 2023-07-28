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
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        readonly ICalculatorServices _service = new CalculatorServiceImp();


        double a, b;
        int op = 0;
        int lastop = 0;
        
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            _service.AddNumber(textBox1.Text);
            if (lastop == 1)
            {
                textBox2.Text = null;
                lastop = 0;
            }
            textBox1.Text += "+";
            textBox2.Text += textBox1.Text;
            

            textBox1.Text = null;
            OperationType b = OperationType.Addition;
                _service.AddOperation(b);
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            _service.AddNumber(textBox1.Text);
            if (lastop == 1)
            {
                textBox2.Text = null;
                lastop = 0;
            }
            textBox1.Text += "-";
            textBox2.Text += textBox1.Text;
            textBox1.Text = null;
            OperationType b = OperationType.Subtraction;
                _service.AddOperation(b);
          

        }
        private void button3_Click(object sender, EventArgs e)
        {
            _service.AddNumber(textBox1.Text);

            textBox2.Text += textBox1.Text;
            textBox2.Text += "=";
            lastop = 1;
            string x;
            x=_service.GetResult().ToString();
            textBox1.Text = null;
            textBox1.Text += x;
            textBox2.Text += x;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";

            
        }
        private void button5_Click(object sender, EventArgs e)
        {
            _service.AddNumber(textBox1.Text);
            if (lastop == 1)
            {
                textBox2.Text = null;
                lastop = 0;
            }
            textBox1.Text += "*";
            textBox2.Text += textBox1.Text;
            textBox1.Text = null;

            OperationType b = OperationType.Multiplication;
                _service.AddOperation(b);
           

        }
        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";

        }
        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";

        }
        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";

        }
        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";

        }
        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += '6';

        }
        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";

        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";

        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";

        }
        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";

        }
        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";

        }
        private void button16_Click(object sender, EventArgs e)
        {
            _service.AddOperation(OperationType.PlusMinus);

        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            _service.CancelAllEntries();
        }
        private void button18_Click(object sender, EventArgs e)
        {
            _service.AddNumber(textBox1.Text);
            if (lastop == 1)
            {
                textBox2.Text = null;
                lastop = 0;
            }
            textBox1.Text += "^2";
            _service.AddOperation(OperationType.Squared);

        }
        private void button19_Click(object sender, EventArgs e)
        {

            _service.AddOperation(OperationType.Inverse);

        }
        private void button20_Click(object sender, EventArgs e)
        {

            _service.AddOperation(OperationType.Sqrt);

        }
        private void button21_Click(object sender, EventArgs e)
        {
            _service.AddNumber(textBox1.Text);
            if (lastop == 1)
            {
                textBox2.Text = null;
                lastop = 0;
            }
            textBox1.Text += "%";

            _service.AddOperation(OperationType.Module);

        }

        private void button22_Click(object sender, EventArgs e)
        {
            
            _service.CancelEntry();
        }
        private void button23_Click(object sender, EventArgs e)
        {

            _service.AddOperation(OperationType.EraseLastDigit);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            _service.AddNumber(textBox1.Text);
            if (lastop == 1)
            {
                textBox2.Text = null;
                lastop = 0;
            }
            textBox1.Text += "/";
            textBox2.Text += textBox1.Text;
            textBox1.Text = null;
            _service.AddOperation(OperationType.Division);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
