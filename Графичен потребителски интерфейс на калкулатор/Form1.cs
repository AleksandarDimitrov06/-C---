using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Графичен_потребителски_интерфейс_на_калкулатор
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        decimal value1 = 0;
        decimal value2 = 0;
        decimal result = 0;
        string operators = "+";

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text += "6";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text += "4";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text += "7";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text += "8";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text += "9";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text += "5";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text += "1";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text += "2";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text += "3";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text += "0";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains("."))
            {
                textBox1.Text = textBox1.Text + ".";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            value1 = decimal.Parse(textBox1.Text);
            textBox1.Clear();
            operators = "+";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            value1 = decimal.Parse(textBox1.Text);
            textBox1.Clear();
            operators = "-";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            value1 = decimal.Parse(textBox1.Text);
            textBox1.Clear();
            operators = "*";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            value1 = decimal.Parse(textBox1.Text);
            textBox1.Clear();
            operators = "/";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            switch (operators)
            {
                case "+":
                    value2 = decimal.Parse(textBox1.Text);
                    result = value1 + value2;
                    textBox1.Text = result.ToString();
                    break;
                case "-":
                    value2 = decimal.Parse(textBox1.Text);
                    result = value1 - value2;
                    textBox1.Text = result.ToString();
                    break;
                case "*":
                    value2 = decimal.Parse(textBox1.Text);
                    result = value1 * value2;
                    textBox1.Text = result.ToString();
                    break;
                case "/":
                    value2 = decimal.Parse(textBox1.Text);
                    result = value1 / value2;
                    textBox1.Text = result.ToString();
                    break;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }
    }
}
