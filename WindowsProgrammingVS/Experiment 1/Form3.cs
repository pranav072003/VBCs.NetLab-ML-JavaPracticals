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
            float result = (float)a / (float)b;
            MessageBox.Show(result.ToString(), "Float Division Result");
        }

        private void button_sqrt_Click(object sender, EventArgs e)
        {
            int a = Int32.Parse(textbox_num1.Text);
            int b = Int32.Parse(textbox_num2.Text);
            double result = Math.Sqrt((double) a);
            MessageBox.Show(result.ToString(), "Square Root Result");
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }
    }
}
