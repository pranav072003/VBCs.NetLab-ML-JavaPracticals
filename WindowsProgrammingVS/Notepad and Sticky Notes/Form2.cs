using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_5_Windows_Programming_theory
{
    public partial class Form2 : Form
    {
        public string lines;
        public PictureBox pb = new PictureBox();

        public Form2()
        {
            InitializeComponent();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Exiting application...");
            Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(menu_stickynotes, "Explore the possible options while surfing through the app freely...");
            t.SetToolTip(button_bold, "Click here to bold the written text");
            t.SetToolTip(button_italics, "Click here to set the italic style of written text");
            t.SetToolTip(button_underline, "Click here to get written text underlined");
            t.SetToolTip(button_close, "Click here to close current sticky note");
            t.SetToolTip(button_img, "Click here to add an image on the sticky note");
            t.SetToolTip(button_settings, "Click here to view the settings for the sticky note");
            t.SetToolTip(button_new, "Click here to open a new sticky note");
            t.SetToolTip(button_linethrough, "Click here to format the text as line-through");
            t.SetToolTip(button_list, "Click here to start an organised list in sticky note");

            // display the save dialog for saving file as text file
            saveFileDialog_stickynote.InitialDirectory = @"C:\";
            saveFileDialog_stickynote.RestoreDirectory = true;
            saveFileDialog_stickynote.Title = "Browse the text files and Save As...";
            saveFileDialog_stickynote.Filter = "Sticky Note Files (*.snt)|*.snt|Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            saveFileDialog_stickynote.DefaultExt = "snt";
            saveFileDialog_stickynote.CheckPathExists = true;

            // configure the open file dialog box for opening a new file
            openFileDialog_stickynote.InitialDirectory = @"C:\";
            openFileDialog_stickynote.RestoreDirectory = true;
            openFileDialog_stickynote.Title = "Select a file to open...";
            openFileDialog_stickynote.Filter = "Sticky Note Files (*.snt)|*.snt|Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog_stickynote.DefaultExt = "snt";
            openFileDialog_stickynote.CheckFileExists = true;
            openFileDialog_stickynote.CheckPathExists = true;

            // configure the open file dialog for adding an image to the sticky note
            openFileDialog_img.InitialDirectory = @"C:\";
            openFileDialog_img.RestoreDirectory = true;
            openFileDialog_img.Title = "Select an image to open";
            openFileDialog_img.Filter = "JPEG Images (*.jpeg)|*.jpeg|JPG Images (*.jpg)|*.jpg|GIF Images (*.gif)|*.gif|All Files (*.*)|*.*";
            openFileDialog_img.DefaultExt = "jpeg";
            openFileDialog_img.CheckFileExists = true;
            openFileDialog_img.CheckPathExists = true;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream st;
            // openFileDialog_stickynote.ShowDialog(this);
            if (openFileDialog_stickynote.ShowDialog(this) == DialogResult.OK)
            {
                // open file and read content from it
                if ((st = openFileDialog_stickynote.OpenFile()) != null)
                {
                    string fileName = openFileDialog_stickynote.FileName;
                    string str = File.ReadAllText(fileName);
                    stickynotes_textbox.Text = str;
                }
            }
            else
            {
                // don't proceed forward with saving, thereby causing undefined exception
                return;
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // saveFileDialog_stickynote.ShowDialog(this);
            if (saveFileDialog_stickynote.ShowDialog(this) == DialogResult.Cancel)
            {
                // don't proceed forward with saving, thereby causing undefined exception
                return;
            }
            StreamWriter sw = new StreamWriter(saveFileDialog_stickynote.FileName);
            if (sw == null)
            {
                MessageBox.Show("Error", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            sw.Write(stickynotes_textbox.Text);
            MessageBox.Show("File Save successfull!");
            sw.Close();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Undoing the text operations(with what's available till date in the cache)...", "Info", MessageBoxButtons.OKCancel);
            if (lines.Length == 0)
            {
                MessageBox.Show("Error! No undo can be done. Please try later");
                return;
            }
            stickynotes_textbox.Text = lines;
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string copy_teststring = string.Copy(stickynotes_textbox.Text);
            stickynotes_textbox.Clear();
            stickynotes_textbox.Focus();
            lines = copy_teststring;
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lines = stickynotes_textbox.Text;
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lines.Length == 0)
            {
                MessageBox.Show("No Text to paste!", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Stop);
                return;
            }
            stickynotes_textbox.Focus();
            stickynotes_textbox.Text += lines;
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stickynotes_textbox.Clear();
            stickynotes_textbox.Focus();
        }

        private void dateTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // retrieve and display the current date and time
            var datetime = DateTime.Now;
            string message = "Current Date: " + datetime.Date.ToString();
            message += " , Day is " + datetime.DayOfWeek;
            message += " and Current Time is " + datetime.TimeOfDay.Hours.ToString() + " hours, ";
            message += datetime.TimeOfDay.Minutes.ToString() + " minutes, ";
            message += datetime.TimeOfDay.Seconds.ToString() + " seconds";
            MessageBox.Show(message, "Information about DateTime", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button_new_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            // resets the font style of the textbox
            stickynotes_textbox.Font = DefaultFont;
            if(pb.Image != null)
            {
                pb.Image = null;
                // can use Invalidate method also
                // pb.Invalidate();
            }
            // clear the content of textbox
            stickynotes_textbox.Clear();
            stickynotes_textbox.Focus();
        }

        private void button_bold_Click(object sender, EventArgs e)
        {
            // apply bold style to the text
            stickynotes_textbox.Font = new Font(stickynotes_textbox.Font, FontStyle.Bold);
        }

        private void button_italics_Click(object sender, EventArgs e)
        {
            // apply italics to the text
            stickynotes_textbox.Font = new Font(stickynotes_textbox.Font, FontStyle.Italic);
        }

        private void button_underline_Click(object sender, EventArgs e)
        {
            // apply underlining to the text
            stickynotes_textbox.Font = new Font(stickynotes_textbox.Font, FontStyle.Underline);
        }

        private void button_linethrough_Click(object sender, EventArgs e)
        {
            // apply line-theough to the text
            stickynotes_textbox.Font = new Font(stickynotes_textbox.Font, FontStyle.Strikeout);
        }

        private void button_settings_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please explore the menu bar for the setting configurations...", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        private void button_list_Click(object sender, EventArgs e)
        {
            // organises text as a list
            // sets buletted text indented by 15 pixels from bullet
            stickynotes_textbox.BulletIndent = 15;
            // enable buletting
            stickynotes_textbox.SelectionBullet = true;
        }

        private void button_img_Click(object sender, EventArgs e)
        {
            Stream st;
            // open the File Dialog
            if (openFileDialog_img.ShowDialog(this) == DialogResult.OK)
            {
                pb.Image = null;
                // open the dialog box for selecting a file to open
                if ((st = openFileDialog_img.OpenFile()) != null)
                {
                    string fileName = openFileDialog_img.FileName;
                    // adding an image to the picture box
                    Image img = Image.FromFile(fileName);
                    pb.Image = img;
                    pb.Size = new Size(img.Width, img.Height);
                    // pb.SizeMode = PictureBoxSizeMode.Zoom;
                    pb.Parent = stickynotes_textbox;
                }
            }
            else
            {
                // prevent unhandled exception from occuring
                return;
            }
        }
    }
}
