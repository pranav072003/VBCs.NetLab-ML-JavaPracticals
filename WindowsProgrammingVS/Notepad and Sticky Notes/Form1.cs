namespace Assignment_5_Windows_Programming_theory
{
    public partial class Form1 : Form
    {
        public string lines;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.AutoScroll = true;
            ToolTip t = new ToolTip();
            t.SetToolTip(menu_notepad, "Explore all the available options while surfing through your personalised notepad!");
            // display the save dialog for saving file as text file
            saveFileDialog_notepad.InitialDirectory = @"C:\";
            saveFileDialog_notepad.RestoreDirectory = true;
            saveFileDialog_notepad.Title = "Browse the text files and Save As...";
            saveFileDialog_notepad.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            saveFileDialog_notepad.DefaultExt = "txt";
            // saveFileDialog_notepad.CheckFileExists = true;
            saveFileDialog_notepad.CheckPathExists = true;

            // configure the open file dialog box for opening a new file
            openFileDialog_notepad.InitialDirectory = @"C:\";
            openFileDialog_notepad.RestoreDirectory = true;
            openFileDialog_notepad.Title = "Select file to open...";
            openFileDialog_notepad.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog_notepad.DefaultExt = "txt";
            openFileDialog_notepad.CheckFileExists = true;
            openFileDialog_notepad.CheckPathExists = true;
        }

        private void continue_button_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            this.Hide();
            f.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Exiting the notepad...", "Info", MessageBoxButtons.OK, MessageBoxIcon.None);
            Application.Exit();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream st;
            // openFileDialog_notepad.ShowDialog(this);
            if(openFileDialog_notepad.ShowDialog(this) == DialogResult.OK)
            {
                // open file and read content from it
                if((st = openFileDialog_notepad.OpenFile()) != null)
                {
                    string fileName = openFileDialog_notepad.FileName;
                    string str = File.ReadAllText(fileName);
                    notepad_textbox.Text = str;
                }
            }
            else
            {
                // don't proceed forward with saving, thereby causing undefined exception
                return;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // saveFileDialog_notepad.ShowDialog(this);
            if(saveFileDialog_notepad.ShowDialog(this) == DialogResult.Cancel)
            {
                // don't proceed forward with saving, thereby causing undefined exception
                return;
            }
            StreamWriter sw = new StreamWriter(saveFileDialog_notepad.FileName);
            if (sw == null)
            {
                MessageBox.Show("Error", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            sw.Write(notepad_textbox.Text);
            MessageBox.Show("File Save successfull!");
            sw.Close();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // saveFileDialog_notepad.ShowDialog(this);
            if (saveFileDialog_notepad.ShowDialog(this) == DialogResult.Cancel)
            {
                // don't proceed forward with saving, thereby causing undefined exception
                return;
            }
            StreamWriter sw = new StreamWriter(saveFileDialog_notepad.FileName);
            sw.Write(notepad_textbox.Text);
            MessageBox.Show("File Save successfull!");
            sw.Close();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notepad_textbox.Clear();
            notepad_textbox.Focus();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string copy_teststring = string.Copy(notepad_textbox.Text);
            notepad_textbox.Clear();
            notepad_textbox.Focus();
            lines = copy_teststring;
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lines = notepad_textbox.Text;
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lines.Length == 0)
            {
                MessageBox.Show("No Text to paste!", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Stop);
                return;
            }
            notepad_textbox.Focus();
            notepad_textbox.Text += lines;
        }

        private void replaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var datetime = DateTime.Now;
            string message = "Current Date: " + datetime.Date.ToString();
            message += " , Day is " + datetime.DayOfWeek;
            message += " and Current Time is " + datetime.TimeOfDay.Hours.ToString() + " hours, ";
            message += datetime.TimeOfDay.Minutes.ToString() + " minutes, ";
            message += datetime.TimeOfDay.Seconds.ToString() + " seconds";
            // message += datetime.TimeOfDay.Milliseconds.ToString() = ""
            MessageBox.Show(message, "Information about DateTime", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // retrieve and display the current date and time
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Undoing the text operations(with what's available till date in the cache)...", "Info", MessageBoxButtons.OKCancel);
            if (lines.Length == 0)
            {
                MessageBox.Show("Error! No undo can be done. Please try later");
                return;
            }
            notepad_textbox.Text = lines;
        }

        private void notepad_textbox_TextChanged(object sender, EventArgs e)
        {
            lines = notepad_textbox.Text;
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Print facility not available yet. Apologies for any inconvenience!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}