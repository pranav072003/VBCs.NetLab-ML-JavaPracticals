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

namespace Programming_in_Windows_Practical_2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label_confirmfname.Text = Form1.Fname;
            label_confirmlname.Text = Form1.Lname;
            label_confirmid.Text = Form1.Email;

            // DONE: add tick symbol for checked services in form 1
            if (Form1.sms)
            {
                label_smsenable.Text = "\u221A";
            }

            if (Form1.reports)
            {
                label_reportenable.Text = "\u221A";
            }

            if (Form1.transactions)
            {
                label_transactionenable.Text = "\u221A";
            }
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Exiting the form....", "Info", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            Environment.Exit(0);
        }
    }
}
