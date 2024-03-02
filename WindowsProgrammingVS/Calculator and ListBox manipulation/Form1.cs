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

namespace Assignment_4_Windows_Programming_theory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            listbox_input.Items.Add(textbox_input.Text);
            textbox_input.Clear();
            textbox_input.Focus();
            listbox_input.Sorted = true;
            int a = listbox_input.Items.Count;
            MessageBox.Show("Number of items currently in the listbox are " + a.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(button_add, "Click here to add your input to the listbox");
            toolTip.SetToolTip(button_remove, "Click here to remove selected item from the listbox");
            toolTip.SetToolTip(button_clear, "Click here to clear the listbox items");
            toolTip.SetToolTip(button_continue, "Click here to continue ahead...");
            toolTip.SetToolTip(button_exit, "Click here to exit the application");
        }

        private void button_remove_Click(object sender, EventArgs e)
        {
            //string id = listbox_input.SelectedItem();
            if (listbox_input.SelectedItem != null)
            {
                listbox_input.Items.Remove(listbox_input.SelectedItem);
            }
            else if(listbox_input.Items.Count > 0)
            {
                MessageBox.Show("Item Selected is null. Please select an item. Deleting the first item by default for you.....", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                listbox_input.Items.Remove(listbox_input.Items[0]);
            }
            else
            {
                MessageBox.Show("List Box is empty. Nothing can be removed...", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);
            }
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Exiting the application....", "Info", MessageBoxButtons.OK, MessageBoxIcon.None);
            Environment.Exit(0);
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            listbox_input.Items.Clear();
        }

        private void button_continue_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f = new Form2();
            f.Show();
        }
    }
}
