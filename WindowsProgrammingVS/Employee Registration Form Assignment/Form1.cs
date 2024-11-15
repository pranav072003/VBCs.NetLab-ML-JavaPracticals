﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Assignment_3_Windows_Programming_theory
{
    public partial class Form1 : Form
    {
        public static string Name;
        public static string EmpID;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // written by mistake. Please ignore
        }

        private void button_continue_Click(object sender, EventArgs e)
        {
            if (textbox_empid.Text.All(char.IsDigit))
            {
                Name = textbox_name.Text;
                EmpID = textbox_empid.Text;
                this.Hide();
                Form2 f = new Form2();
                f.Show();
            }
            else
            {
                MessageBox.Show("Employee ID cannot have non-digit values", "Alert");
            }
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            textbox_name.Text = "";
            textbox_empid.Text = "";
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Exiting the application...", "Information", MessageBoxButtons.OK, MessageBoxIcon.None);
            Environment.Exit(0);
        }
    }
}
