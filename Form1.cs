using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        decimal num1, num2, result;
        string operate = "";
        bool isOperand = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isOperand)
            {
                textBox1.Text = "";
                isOperand = false;
            }
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (isOperand)
            {
                textBox1.Text = "";
                isOperand = false;
            }
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (isOperand)
            {
                textBox1.Text = "";
                isOperand = false;
            }
            textBox1.Text += "3";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (isOperand)
            {
                textBox1.Text = "";
                isOperand = false;
            }
            textBox1.Text += "4";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (isOperand)
            {
                textBox1.Text = "";
                isOperand = false;
            }
            textBox1.Text += "5";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (isOperand)
            {
                textBox1.Text = "";
                isOperand = false;
            }
            textBox1.Text += "6";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (isOperand)
            {
                textBox1.Text = "";
                isOperand = false;
            }
            textBox1.Text += "7";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (isOperand)
            {
                textBox1.Text = "";
                isOperand = false;
            }
            textBox1.Text += "8";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (isOperand)
            {
                textBox1.Text = "";
                isOperand = false;
            }
            textBox1.Text += "9";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (isOperand)
            {
                textBox1.Text = "";
                isOperand = false;
            }
            textBox1.Text += "0";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (!isOperand && label1.Text.Length <= 0) return;
            label1.Text += textBox1.Text + " = ";
            this.Calculate();
            operate = "=";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = "";
            operate = "";
            isOperand = false;
            num1 = num2 = result = 0;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                if (operate == "" || operate == "=")
                {
                    label1.Text += textBox1.Text + " - ";
                    num1 = Decimal.Parse(textBox1.Text);
                    operate = "-";
                    isOperand = true;
                }
                else
                {
                    label1.Text += textBox1.Text + " - ";
                    this.Calculate();
                    operate = "-";
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                if (operate == "" || operate == "=")
                {
                    label1.Text += textBox1.Text + " x ";
                    num1 = Decimal.Parse(textBox1.Text);
                    operate = "*";
                    isOperand = true;
                }
                else
                {
                    label1.Text += textBox1.Text + " x ";
                    this.Calculate();
                    operate = "*";
                }
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                if (operate == "" || operate == "=")
                {
                    label1.Text += textBox1.Text + " ÷ ";
                    num1 = Decimal.Parse(textBox1.Text);
                    operate = "/";
                    isOperand = true;
                }
                else
                {
                    label1.Text += textBox1.Text + " ÷ ";
                    this.Calculate();
                    operate = "/";
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (isOperand)
            {
                textBox1.Text = "";
                isOperand = false;
            }

            if (!textBox1.Text.Contains("."))
            {
                if (textBox1.Text.Length == 0)
                {
                    textBox1.Text += "0.";
                }
                else
                {
                    textBox1.Text += ".";
                }
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
            else
            {
                MessageBox.Show("ลบไม่ได้แล้ววววว");
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                if (operate == "" || operate == "=")
                {
                    label1.Text += textBox1.Text + " + ";
                    num1 = Decimal.Parse(textBox1.Text);
                    operate = "+";
                    isOperand = true;
                }
                else
                {
                    label1.Text += textBox1.Text + " + ";
                    this.Calculate();
                    operate = "+";
                }
            }
        }

        private void Calculate()
        {
            if (textBox1.Text == "0" && operate == "/")
            {
                MessageBox.Show("ไม่สามารถหารด้วย 0 ได้");
                return;
            }
            switch (operate)
            {
                case "+":
                    result = num1 + Decimal.Parse(textBox1.Text);
                    break;
                case "-":
                    result = num1 - Decimal.Parse(textBox1.Text);
                    break;
                case "*":
                    result = num1 * Decimal.Parse(textBox1.Text);
                    break;
                case "/":
                    result = num1 / Decimal.Parse(textBox1.Text);
                    break;
            }
            num1 = result;
            isOperand = true;
            textBox1.Text = result.ToString();
        }
    }
}
