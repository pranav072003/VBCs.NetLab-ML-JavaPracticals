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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_select_Click(object sender, EventArgs e)
        {
            label_hi.Text = "Hello World Again!.......";
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            label_hi.Text = "We are cancelling.......";
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f = new Form2();
            f.Show();
        }

        private void button_continue_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f = new Form3();
            f.Show();
        }
    }
}
