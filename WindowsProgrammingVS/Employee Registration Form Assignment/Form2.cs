using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_3_Windows_Programming_theory
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void button_continue_Click(object sender, EventArgs e)
        {
            string DOB = date_birth.Text;
            string DOJ = dateTimePicker1.Text;
            string result = "Your Date of birth is " + DOB + " and your date of joining is " + DOJ;
            MessageBox.Show(result, "Status");
            this.Hide();
            Form3 f = new Form3();
            f.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "Hello! Your name and employee ID have been recorded";
        }
    }
}
