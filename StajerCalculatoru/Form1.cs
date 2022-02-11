using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StajerCalculatoru
{
    public partial class Form1 : Form
    {
        CalStatus myStatus = CalStatus.firstValue;
        Operation myOperation;
        double firstValue;
        double secondValue;
          
        public Form1()
        {
            InitializeComponent();
        }

        private void processNumber(int v)
        {
            switch (myStatus)
            {
                case CalStatus.firstValue:
                    textBoxSonuc.Text += v.ToString();
                    break;
                case CalStatus.secondFirstWiting:
                    textBoxSonuc.Text = v.ToString();
                    myStatus = CalStatus.SecondValue;
                    break;
                case CalStatus.SecondValue:
                    textBoxSonuc.Text += v.ToString();
                    break;
                default:
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            processNumber(1);
        }
    
        private void button2_Click(object sender, EventArgs e)
        {
            processNumber(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            processNumber(3);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            processNumber(4);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            processNumber(8);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            processOperation(Operation.subs);

        }       

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (textBoxSonuc.Text.Length==0)
            {
                textBoxSonuc.Clear();
            }
            else
            {
                textBoxSonuc.Text = textBoxSonuc.Text.Remove(textBoxSonuc.Text.Length - 1);
            }
                  
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBoxSonuc.Clear();
            textBox1.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            processNumber(5);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            processNumber(6);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            processNumber(7);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            processNumber(9);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            processNumber(0);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            processOperation(Operation.mult);
        }

        private void processOperation(Operation oper)
        {
            if (myStatus==CalStatus.firstValue)
            {
                processNumber(0);
            }

            myOperation = oper;
            myStatus = CalStatus.secondFirstWiting;
            firstValue = Convert.ToDouble(textBoxSonuc.Text);
            textBox1.Text = textBoxSonuc.Text + " ";

            switch (oper)
            {
                case Operation.add:
                    textBox1.Text += "+";
                    break;
                case Operation.subs:
                    textBox1.Text += "-";
                    break;
                case Operation.mult:
                    textBox1.Text += "x";
                    break;
                case Operation.divide:
                    textBox1.Text += "/";
                    break;
                default:
                    break;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            processOperation(Operation.add);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            processOperation(Operation.divide);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            secondValue = Convert.ToDouble(textBoxSonuc.Text);
            switch (myOperation)
            {
                case Operation.add:
                    textBoxSonuc.Text = Convert.ToString(firstValue + secondValue);
                    myStatus = CalStatus.firstValue;
                    break;
                case Operation.subs:
                    textBoxSonuc.Text = Convert.ToString(firstValue - secondValue);
                    myStatus = CalStatus.firstValue;
                    break;
                case Operation.mult:
                    textBoxSonuc.Text = Convert.ToString(firstValue * secondValue);
                    myStatus = CalStatus.firstValue;
                    break;
                case Operation.divide:
                    textBoxSonuc.Text = Convert.ToString(firstValue / secondValue);
                    myStatus = CalStatus.firstValue;
                    break;
                default:
                    break;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxSonuc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
