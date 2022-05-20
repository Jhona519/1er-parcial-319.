using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        double primero = 0, segundo = 0;
        string operador = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            txtResultado.Clear();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if(txtResultado.Text.Trim() == string.Empty)
            {
                return;
            }
            primero = Convert.ToDouble(txtResultado.Text);
            operador = "/";
            txtResultado.Clear();

        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text.Trim() == string.Empty)
            {
                return;
            }
            primero = Convert.ToDouble(txtResultado.Text);
            operador = "*";
            txtResultado.Clear();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text.Trim() == string.Empty)
            {
                return;
            }
            primero = Convert.ToDouble(txtResultado.Text);
            operador = "-";
            txtResultado.Clear();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text.Trim() == string.Empty)
            {
                return;
            }
            primero = Convert.ToDouble(txtResultado.Text);
            operador = "+";
            txtResultado.Clear();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text.Trim() == string.Empty)
            {
                return;
            }
            segundo = Convert.ToDouble(txtResultado.Text);
            switch(operador)
            {
                case "+":
                    txtResultado.Text = (primero + segundo).ToString();
                    break;
                case "-":
                    txtResultado.Text = (primero - segundo).ToString();
                    break;
                case "/":
                    txtResultado.Text = (primero / segundo).ToString();
                    break;
                case "*":
                    txtResultado.Text = (primero * segundo).ToString();
                    break;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }
    }
}
