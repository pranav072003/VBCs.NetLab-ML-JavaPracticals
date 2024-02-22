using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApppracticalexp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            string user_id = textbox_userid.Text;
            string password = textbox_password.Text;
            if(user_id=="Chandni" && password=="123456")
            {
                MyWinApp f = new MyWinApp();
                f.Show();
            }
            else
            {
                MessageBox.Show("Password or User ID is incorrect");
            }
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            textbox_userid.Text = "";
            textbox_password.Text = "";
        }
    }
}
