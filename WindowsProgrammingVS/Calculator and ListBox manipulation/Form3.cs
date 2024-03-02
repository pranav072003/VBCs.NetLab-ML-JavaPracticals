using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Assignment_4_Windows_Programming_theory
{
    public partial class Form3 : Form
    {
        public static string num1="";
        public static string num2="";
        public static string op="";

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            richtextbox_calcinput.Text = "0";
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(button_back, "Click here to go back");
            toolTip.SetToolTip(button_exit, "Click here to exit the application");
            toolTip.SetToolTip(label_calculator, "Please note that at once, only operation" +
                " on two numbers is allowed. Therefore, user is advised to take care of the" +
                " precedence of the operators while performing mathematical computations");
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f = new Form2();
            f.Show();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Exiting the application...", "Info", MessageBoxButtons.OK, MessageBoxIcon.None);
            Environment.Exit(0);
        }

        private void button_0_Click(object sender, EventArgs e)
        {
            string text = richtextbox_calcinput.Text;
            if (text == "0")
            {
                richtextbox_calcinput.Clear();
                richtextbox_calcinput.Focus();
                richtextbox_calcinput.Text = "0";
            }
            else if (text[0] == '0')
            {
                text.Remove(0);
                text += "0";
                richtextbox_calcinput.Text = text;
            }
            else if (text == "+" || text == "-" || text == "*" || text == "/")
            {
                op = text;
                richtextbox_calcinput.Clear();
                richtextbox_calcinput.Focus();
                richtextbox_calcinput.Text = "0";
            }
            else
            {
                text += "0";
                richtextbox_calcinput.Text = text;
            }
        }

        private void button_8_Click(object sender, EventArgs e)
        {
            string text = richtextbox_calcinput.Text;
            if (text == "0")
            {
                richtextbox_calcinput.Clear();
                richtextbox_calcinput.Focus();
                richtextbox_calcinput.Text = "8";
            }
            else if (text[0] == '0')
            {
                text.Remove(0);
                text += "8";
                richtextbox_calcinput.Text = text;
            }
            else if (text == "+" || text == "-" || text == "*" || text == "/")
            {
                op = text;
                richtextbox_calcinput.Clear();
                richtextbox_calcinput.Focus();
                richtextbox_calcinput.Text = "8";
            }
            else
            {
                text += "8";
                richtextbox_calcinput.Text = text;
            }
        }

        private void button_7_Click(object sender, EventArgs e)
        {
            string text = richtextbox_calcinput.Text;
            if (text == "0")
            {
                richtextbox_calcinput.Clear();
                richtextbox_calcinput.Focus();
                richtextbox_calcinput.Text = "7";
            }
            else if (text[0] == '0')
            {
                text.Remove(0);
                text += "7";
                richtextbox_calcinput.Text = text;
            }
            else if (text == "+" || text == "-" || text == "*" || text == "/")
            {
                op = text;
                richtextbox_calcinput.Clear();
                richtextbox_calcinput.Focus();
                richtextbox_calcinput.Text = "7";
            }
            else
            {
                text += "7";
                richtextbox_calcinput.Text = text;
            }
        }

        private void button_9_Click(object sender, EventArgs e)
        {
            string text = richtextbox_calcinput.Text;
            if (text == "0")
            {
                richtextbox_calcinput.Clear();
                richtextbox_calcinput.Focus();
                richtextbox_calcinput.Text = "9";
            }
            else if (text[0] == '0')
            {
                text.Remove(0);
                text += "9";
                richtextbox_calcinput.Text = text;
            }
            else if (text == "+" || text == "-" || text == "*" || text == "/")
            {
                op = text;
                richtextbox_calcinput.Clear();
                richtextbox_calcinput.Focus();
                richtextbox_calcinput.Text = "9";
            }
            else
            {
                text += "9";
                richtextbox_calcinput.Text = text;
            }
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            string text = richtextbox_calcinput.Text;
            if (text == "0")
            {
                richtextbox_calcinput.Clear();
                richtextbox_calcinput.Focus();
                richtextbox_calcinput.Text = "4";
            }
            else if (text[0] == '0')
            {
                text.Remove(0);
                text += "4";
                richtextbox_calcinput.Text = text;
            }
            else if (text == "+" || text == "-" || text == "*" || text == "/")
            {
                op = text;
                richtextbox_calcinput.Clear();
                richtextbox_calcinput.Focus();
                richtextbox_calcinput.Text = "4";
            }
            else
            {
                text += "4";
                richtextbox_calcinput.Text = text;
            }
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            string text = richtextbox_calcinput.Text;
            if (text == "0")
            {
                richtextbox_calcinput.Clear();
                richtextbox_calcinput.Focus();
                richtextbox_calcinput.Text = "5";
            }
            else if (text[0] == '0')
            {
                text.Remove(0);
                text += "5";
                richtextbox_calcinput.Text = text;
            }
            else if (text == "+" || text == "-" || text == "*" || text == "/")
            {
                op = text;
                richtextbox_calcinput.Clear();
                richtextbox_calcinput.Focus();
                richtextbox_calcinput.Text = "5";
            }
            else
            {
                text += "5";
                richtextbox_calcinput.Text = text;
            }
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            string text = richtextbox_calcinput.Text;
            if (text == "0")
            {
                richtextbox_calcinput.Clear();
                richtextbox_calcinput.Focus();
                richtextbox_calcinput.Text = "6";
            }
            else if (text[0] == '0')
            {
                text.Remove(0);
                text += "6";
                richtextbox_calcinput.Text = text;
            }
            else if (text == "+" || text == "-" || text == "*" || text == "/")
            {
                op = text;
                richtextbox_calcinput.Clear();
                richtextbox_calcinput.Focus();
                richtextbox_calcinput.Text = "6";
            }
            else
            {
                text += "6";
                richtextbox_calcinput.Text = text;
            }
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            string text = richtextbox_calcinput.Text;
            if (text == "0")
            {
                richtextbox_calcinput.Clear();
                richtextbox_calcinput.Focus();
                richtextbox_calcinput.Text = "1";
            }
            else if (text[0] == '0')
            {
                text.Remove(0);
                text += "1";
                richtextbox_calcinput.Text = text;
            }
            else if (text == "+" || text == "-" || text == "*" || text == "/")
            {
                op = text;
                richtextbox_calcinput.Clear();
                richtextbox_calcinput.Focus();
                richtextbox_calcinput.Text = "1";
            }
            else
            {
                text += "1";
                richtextbox_calcinput.Text = text;
            }
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            string text = richtextbox_calcinput.Text;
            if (text == "0")
            {
                richtextbox_calcinput.Clear();
                richtextbox_calcinput.Focus();
                richtextbox_calcinput.Text = "2";
            }
            else if (text[0] == '0')
            {
                text.Remove(0);
                text += "2";
                richtextbox_calcinput.Text = text;
            }
            else if (text == "+" || text == "-" || text == "*" || text == "/")
            {
                op = text;
                richtextbox_calcinput.Clear();
                richtextbox_calcinput.Focus();
                richtextbox_calcinput.Text = "2";
            }
            else
            {
                text += "2";
                richtextbox_calcinput.Text = text;
            }
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            string text = richtextbox_calcinput.Text;
            if (text == "0")
            {
                richtextbox_calcinput.Clear();
                richtextbox_calcinput.Focus();
                richtextbox_calcinput.Text = "3";
            }
            else if (text[0] == '0')
            {
                text.Remove(0);
                text += "3";
                richtextbox_calcinput.Text = text;
            }
            else if (text == "+" || text == "-" || text == "*" || text == "/")
            {
                op = text;
                richtextbox_calcinput.Clear();
                richtextbox_calcinput.Focus();
                richtextbox_calcinput.Text = "3";
            }
            else
            {
                text += "3";
                richtextbox_calcinput.Text = text;
            }
        }

        private void button_C_Click(object sender, EventArgs e)
        {
            richtextbox_calcinput.Clear();
            richtextbox_calcinput.Focus();
            richtextbox_calcinput.Text = "0";
            num1 = "";
            num2 = "";
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            if (num1.Length != 0 && op.Length != 0 &&
                richtextbox_calcinput.Text.Length != 0)
            {
                // both numbers have been inputted or derived
                MessageBox.Show("More operations cannot be performed, first clear the previous operation query first...", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
            }
            else
            {
                num1 = richtextbox_calcinput.Text;
                richtextbox_calcinput.Clear();
                richtextbox_calcinput.Focus();
                richtextbox_calcinput.Text = "+";
                op = "+";
            }
        }

        private void button_sub_Click(object sender, EventArgs e)
        {
            if (num1.Length != 0 && op.Length != 0 &&
                richtextbox_calcinput.Text.Length != 0)
            {
                // both numbers have been inputted or derived
                MessageBox.Show("More operations cannot be performed, first clear the previous operation query first...", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
            }
            else
            {
                num1 = richtextbox_calcinput.Text;
                richtextbox_calcinput.Clear();
                richtextbox_calcinput.Focus();
                richtextbox_calcinput.Text = "-";
                op = "-";
            }
        }

        private void button_mul_Click(object sender, EventArgs e)
        {
            if (num1.Length != 0 && op.Length != 0 &&
                richtextbox_calcinput.Text.Length != 0)
            {
                // both numbers have been inputted or derived
                MessageBox.Show("More operations cannot be performed, first clear the previous operation query first...", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
            }
            else
            {
                num1 = richtextbox_calcinput.Text;
                richtextbox_calcinput.Clear();
                richtextbox_calcinput.Focus();
                richtextbox_calcinput.Text = "*";
                op = "*";
            }
        }

        private void button_div_Click(object sender, EventArgs e)
        {
            if (num1.Length != 0 && op.Length != 0 && 
                richtextbox_calcinput.Text.Length != 0)
            {
                // both numbers have been inputted or derived
                MessageBox.Show("More operations cannot be performed, first clear the previous operation query first...", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
            }
            else
            {
                num1 = richtextbox_calcinput.Text;
                richtextbox_calcinput.Clear();
                richtextbox_calcinput.Focus();
                richtextbox_calcinput.Text = "/";
                op = "/";
            }
        }

        private void button_eq_Click(object sender, EventArgs e)
        {
            if(num1.Length==0 || richtextbox_calcinput.Text=="+" || 
                richtextbox_calcinput.Text=="-" || richtextbox_calcinput.Text=="*"
                || richtextbox_calcinput.Text=="/")
            {
                MessageBox.Show("Missing one input...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                num2 = richtextbox_calcinput.Text;
                richtextbox_calcinput.Clear();
                richtextbox_calcinput.Focus();
                // we have both the inputs present
                int a = Convert.ToInt32(num1);
                int b = Convert.ToInt32(num2);
                string operation = op;
                int result;
                switch(operation)
                {
                    case "+":
                        result = a + b;
                        num1 = result.ToString();
                        num2 = "";
                        richtextbox_calcinput.Text = result.ToString();
                        op = "";
                        break;
                    case "-":
                        result = a - b;
                        num1 = result.ToString();
                        num2 = "";
                        richtextbox_calcinput.Text = result.ToString();
                        op = "";
                        break;
                    case "*":
                        result = a * b;
                        num1 = result.ToString();
                        num2 = "";
                        richtextbox_calcinput.Text = result.ToString();
                        op = "";
                        break;
                    case "/":
                        // storing int division result, limitation we cannot solve
                        result = a / b;
                        num1 = result.ToString();
                        num2 = "";
                        richtextbox_calcinput.Text = result.ToString();
                        op = "";
                        break;
                    default:
                        MessageBox.Show("No operation?","Info");
                        break;
                }
            }
        }
    }
}
