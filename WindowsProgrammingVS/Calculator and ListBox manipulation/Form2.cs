using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_4_Windows_Programming_theory
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button_continue_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f = new Form3();
            f.Show();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(listbox_choice, "Select a choice to open sub-options for each related option selected");
            toolTip.SetToolTip(button_continue, "Click here to continue ahead");
            toolTip.SetToolTip(button_back, "Click here to go back");
            toolTip.SetToolTip(button_reset, "Click here to reset contents of listbox");
        }

        private void listbox_choice_SelectedIndexChanged(object sender, EventArgs e)
        {
            // DONE: add the select logic here
            string[] sub_CSE = new string[] {"Theory of Computation","Computer Networks",
            "Digital Logic and Computer Design","Database Management System"};
            string[] sub_IT = new string[] {"Foundation of Computer Science", "Operating System",
            "Compiler Design","Data Structures and Algorithms"};
            string[] sub_ECE = new string[] { "Signals and Systems", "Analog Electronics",
            "Digital Electronics","Digital Signal Processing","Microprocessor Interfacing"};

            int length;
            string text;
            // select logic starts from here
            if (listbox_choice.SelectedIndex == 0 && listbox_choice.SelectedItem == "CSE")
            {
                // for CSE
                text = listbox_choice.GetItemText(listbox_choice.SelectedItem);
                listbox_choice.Items.Clear();
                listbox_choice.Items.Add("Subjects for " + text + " are:-");
                length = sub_CSE.Length;
                for (int i = 0; i < length; i++)
                {
                    listbox_choice.Items.Add(sub_CSE[i]);
                }
            }
            else if (listbox_choice.SelectedIndex == 1 && listbox_choice.SelectedItem == "IT")
            {
                // for IT
                text = listbox_choice.GetItemText(listbox_choice.SelectedItem);
                listbox_choice.Items.Clear();
                listbox_choice.Items.Add("Subjects for " + text + " are:-");
                length = sub_IT.Length;
                for (int i = 0; i < length; i++)
                {
                    listbox_choice.Items.Add(sub_IT[i]);
                }
            }
            else if(listbox_choice.SelectedItem == "ECE")
            {
                // for ECE
                text = listbox_choice.GetItemText(listbox_choice.SelectedItem);
                listbox_choice.Items.Clear();
                listbox_choice.Items.Add("Subjects for " + text + " are:-");
                length = sub_ECE.Length;
                for (int i = 0; i < length; i++)
                {
                    listbox_choice.Items.Add(sub_ECE[i]);
                }
            }
            else
            {
                // do nothing
            }
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            string[] subjects = new string[] { "CSE", "IT", "ECE" };
            listbox_choice.Items.Clear();
            int length = subjects.Length;
            for(int i= 0; i < length;i++)
            {
                listbox_choice.Items.Add(subjects[i]);
            }
        }
    }
}
