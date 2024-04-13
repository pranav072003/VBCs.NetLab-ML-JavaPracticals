using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File_operations_in_dotnet
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            Hide();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button_write_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(textbox_filepath.Text, FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(richtextbox_filewrite.Text);
            sw.Flush();
            fs.Close();
            MessageBox.Show("Content is written in file successfully");
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(button_back, "Click here to go back");
            t.SetToolTip(button_exit, "Click here exit the app..");
            t.SetToolTip(button_write, "Click here to write content to the file path");
            t.SetToolTip(button_read, "Click here to read content from the file");
            t.SetToolTip(button_find, "Click here to find the text within the file");
        }

        private void button_read_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(textbox_filepath.Text, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            richtextbox_fileread.Text = sr.ReadToEnd();
            fs.Close();
        }

        private void button_find_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(textbox_filepath.Text, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            String str = sr.ReadToEnd();
            int i = (str.IndexOf(richtextbox_filesearch.Text,0));
            if (i > -1) // -1 used to denote E.O.F similar to Python last index used as -1
            {
                MessageBox.Show("This word exists in file");
            }
            else
            {
                MessageBox.Show("This word does not exist in the file");
            }
        }
    }
}
