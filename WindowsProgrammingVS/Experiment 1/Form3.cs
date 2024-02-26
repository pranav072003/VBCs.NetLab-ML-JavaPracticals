using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming_in_Windows_Practical_1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            int a = Int32.Parse(textbox_num1.Text);
            int b = Int32.Parse(textbox_num2.Text);
            int result = a + b;
            MessageBox.Show(result.ToString(), "Addition Result");
        }

        private void button_sub_Click(object sender, EventArgs e)
        {
            int a = Int32.Parse(textbox_num1.Text);
            int b = Int32.Parse(textbox_num2.Text);
            int result = a - b;
            MessageBox.Show(result.ToString(), "Subtraction Result");
        }

        private void button_divide_Click(object sender, EventArgs e)
        {
            int a = Int32.Parse(textbox_num1.Text);
            int b = Int32.Parse(textbox_num2.Text);
            if(b!=0)
            {
                float result = (float)a / (float)b;
                MessageBox.Show(result.ToString(), "Float Division Result");
            }
            else
            {
                MessageBox.Show("Denominator cannot be zero!", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
        }

        private void button_sqrt_Click(object sender, EventArgs e)
        {
            int a = Int32.Parse(textbox_num1.Text);
            int b = Int32.Parse(textbox_num2.Text);
            if(a>=0 && b>=0)
            {
                double result1 = Math.Sqrt((double)a);
                double result2 = Math.Sqrt((double)b);
                MessageBox.Show(result1.ToString(), "Square Root Result of 1st Number");
                MessageBox.Show(result2.ToString(), "Square Root Result of 2nd Number");
            }
            else if(a<0 && b>=0)
            {
                double result1 = Math.Sqrt((double)(-1)*a);
                double result2 = Math.Sqrt((double)b);
                MessageBox.Show(result1.ToString()+"j", "Square Root Result of 1st Number");
                MessageBox.Show(result2.ToString(), "Square Root Result of 2nd Number");
            }
            else if(b<0 && a>=0)
            {
                double result1 = Math.Sqrt((double)a);
                double result2 = Math.Sqrt((double)(-1) * b);
                MessageBox.Show(result1.ToString(), "Square Root Result of 1st Number");
                MessageBox.Show(result2.ToString() + "j", "Square Root Result of 2nd Number");
            }
            else
            {
                double result1 = Math.Sqrt((double)(-1) *a);
                double result2 = Math.Sqrt((double)(-1) * b);
                MessageBox.Show(result1.ToString() + "j", "Square Root Result of 1st Number");
                MessageBox.Show(result2.ToString() + "j", "Square Root Result of 2nd Number");
            }
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void button_multiply_Click(object sender, EventArgs e)
        {
            int a = Int32.Parse(textbox_num1.Text);
            int b = Int32.Parse(textbox_num2.Text);
            int result = a * b;
            MessageBox.Show(result.ToString(), "Multiplication Result");
        }

        private void button_square_Click(object sender, EventArgs e)
        {
            int a = Int32.Parse(textbox_num1.Text);
            int b = Int32.Parse(textbox_num2.Text);
            int result1 = a * a;
            int result2 = b * b;
            MessageBox.Show(result1.ToString(), "Square of First Number");
            MessageBox.Show(result2.ToString(), "Square of Second Number");
        }
    }
}
