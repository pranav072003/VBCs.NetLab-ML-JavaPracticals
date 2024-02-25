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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void radiobutton_hrd_CheckedChanged(object sender, EventArgs e)
        {
            // written by mistake. Please ignore
        }

        private void radiobutton_prod_CheckedChanged(object sender, EventArgs e)
        {
            // written by mistake. Please ignore
        }

        private void button_submit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
            MessageBox.Show("Your information has been recorded successfully. Thanks for registering!");
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f = new Form2();
            f.Show();
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            textbox_address.Text = "";
            textbox_emailid.Text = "";
            textbox_number.Text = "";
        }
    }
}
