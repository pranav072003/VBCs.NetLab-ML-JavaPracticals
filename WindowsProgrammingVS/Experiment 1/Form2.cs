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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            if (textbox_userid.Text == "Pranav" && textbox_password.Text == "3486")
            {
                this.Hide();
                Form1 f = new Form1();
                f.Show();
            }
            else
            {
                MessageBox.Show("User ID or Password is incorrect", "Error");
            }
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            textbox_userid.Text = "";
            textbox_password.Text = "";
        }
    }
}
