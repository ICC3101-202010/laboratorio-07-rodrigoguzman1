using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio7
{
    public partial class Form1 : Form
    {

        double numero1;
        double numero2;
        double resultado;
        string operador;
        double ans;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                numero1 = Convert.ToDouble(textBox1.Text);
                operador = "X";
                textBox1.Text = "";
            }
            catch (Exception)
            {
                textBox1.Text = "Syntax Error";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                numero1 = Convert.ToDouble(textBox1.Text);
                operador = "/";
                textBox1.Text = "";
            }
            catch (Exception)
            {
                textBox1.Text = "Syntax Error";
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            try
            {
                numero1 = Convert.ToDouble(textBox1.Text);
                operador = "-";
                textBox1.Text = "";
            }
            catch (Exception)
            {
                textBox1.Text = "Syntax Error";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                numero1 = Convert.ToDouble(textBox1.Text);
                operador = "+";
                textBox1.Text = "";
            }
            catch (Exception)
            {
                textBox1.Text = "Syntax Error";
            }
            
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(ans);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            try
            {
                numero2 = Convert.ToDouble(textBox1.Text);
                switch (operador)
                {
                    case "+":
                        resultado = numero1 + numero2;
                        break;
                    case "-":
                        resultado = numero1 - numero2;
                        break;
                    case "X":
                        resultado = numero1 * numero2;
                        break;
                    case "/":
                        resultado = numero1 / numero2;
                        break;
                    default:
                        break;
                }
                if (Double.IsInfinity(resultado)) { textBox1.Text = "Math Error"; }
                else
                {
                    textBox1.Text = Convert.ToString(resultado);
                    ans = resultado;
                }
            }
            catch (Exception)
            {
                textBox1.Text = "Math Error";
            }
            
        }
    }
}
