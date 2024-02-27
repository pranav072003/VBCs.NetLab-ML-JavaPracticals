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
            if((textbox_address.Text.Length >0) && (textbox_emailid.Text.Length>0) && (textbox_number.Text.Length>0))
            {
                this.Hide();
                Form1 f = new Form1();
                f.Show();
                MessageBox.Show("Your information has been recorded successfully. Thanks for registering!");
            }
            else
            {
                MessageBox.Show("Input entries cannot be blank!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f = new Form2();
            f.Show();
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            combobox_gender.DisplayMember = "";
            if(radiobutton_acc.Checked)
            {
                radiobutton_acc.Checked = false;
            }
            if(radiobutton_hrd.Checked)
            {
                radiobutton_hrd.Checked = false;
            }
            if(radiobutton_prod.Checked)
            {
                radiobutton_prod.Checked = false;
            }    
            if(radiobutton_pr.Checked)
            {
                radiobutton_pr.Checked = false;
            }
            if(radiobutton_marketing.Checked)
            {
                radiobutton_marketing.Checked = false;
            }
            if(radiobutton_it.Checked)
            {
                radiobutton_it.Checked = false; 
            }
            textbox_address.Text = "";
            textbox_emailid.Text = "";
            textbox_number.Text = "";
        }
    }
}
