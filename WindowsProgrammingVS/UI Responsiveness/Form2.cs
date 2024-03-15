using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIResponsiveness_PrgmInWindows
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.StartPosition = FormStartPosition.CenterParent;
            ToolTip t = new ToolTip();
            t.SetToolTip(textbox_userid, "Enter your user ID");
            t.SetToolTip(textbox_password, "Enter password");
            // t.SetToolTip()
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            if (textbox_userid.Text == "Pranav" && textbox_password.Text == "3486")
            {
                MessageBox.Show("Successful Login! Hi " + textbox_userid.Text);
                Form3 f = new Form3();
                this.Hide();
                f.Show();
            }
            else if (textbox_userid.Text.Length == 0 || textbox_password.Text.Length == 0)
            {
                MessageBox.Show("Error! Input empty", "Alert");
            }
            else if (textbox_password.Text.Length > textbox_password.MaxLength)
            {
                MessageBox.Show("Password length exceeding max length", "Alert");
            }
            else
            {
                MessageBox.Show("Wrong login! Try again.");
            }
        }

        private void textbox_password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
