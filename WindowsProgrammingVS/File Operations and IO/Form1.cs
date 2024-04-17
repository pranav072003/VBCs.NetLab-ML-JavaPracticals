using System.IO;

namespace File_operations_in_dotnet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = "C:/Users/Pranav Jain/Desktop/Gate paper 2024/6th Semester/Prgm in Windows/demo-file.txt";
            // string folder_path = "C:/Users/Pranav Jain/Desktop/Gate paper 2024/6th Semester/Prgm in Windows/demo-folder";
            if (File.Exists(path))
            {
                // check whether a file with the same path already exists or not
                DialogResult result = MessageBox.Show("File already exists!");
                return;
            }
            /*if (!Directory.Exists(folder_path))
            {
                // check whether a folder with name does not exists or not
                Directory.CreateDirectory(folder_path);
            }*/

            // can alternatively use StreamWriter writer = new StreamWriter(path); also
            // create and write on created file (not inside new created directory)

            // can also use this alternatively
            // StreamWriter streamWriter1 = File.CreateText(path);
            // streamWriter1.WriteLine(richTextBox1.Text);
            // streamWriter1.Close();
            using (StreamWriter streamWriter = File.CreateText(path))
            {
                streamWriter.WriteLine(richTextBox1.Text);
            }
            // streamWriter1.WriteLine("Pranav Jain 00516403221");
            // above line works given the streamwriter is closed appropriately after the write operation
            // has been performed

            // string file_folder_path = Path.Combine(folder_path, "demo-file.txt");
            // File.Create(file_folder_path).Close(); // create a file and close it immediately
            DialogResult r = MessageBox.Show("Operations applied successfully!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_continue_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string path = "C:/Users/Pranav Jain/Desktop/Gate paper 2024/6th Semester/Prgm in Windows/demo-file.txt";

            if (!File.Exists(path))
            {
                MessageBox.Show("File does not exists");
                return;
            }

            /* string file_text;
            if (textBox1.Text.Length != 0)
            {
                // take in account the position at which text to be written
                int pos_idx = Convert.ToInt32(textBox1.Text);
                StreamReader sr = new StreamReader(path);
                file_text = sr.ReadToEnd();
                sr.Close();  // careful with this: If wither of streamreader or streamwriter left open, unhandled exception error raised
                if (pos_idx > file_text.Length || pos_idx <= 0)
                {
                    MessageBox.Show("Invalid Index! Please try again!");
                    return;
                }
                // append the user entered text to the file at the given position index
                string substr1 = file_text.Substring(0, pos_idx - 1);
                string substr2 = file_text.Substring(pos_idx - 1, file_text.Length - pos_idx + 1);
                file_text = substr1 + " " +  richTextBox1.Text + " " + substr2;
                MessageBox.Show(file_text);
                return;
            }  taken by assuming data to be written at particular index of data */

            // assuming new data to be written at a line index in file
            if (textBox1.Text.Length != 0)
            {
                int lineCount = File.ReadLines(path).Count();
                if (Convert.ToInt32(textBox1.Text) <= lineCount)
                {
                    string[] lines = File.ReadAllLines(path);
                    if (lines[Convert.ToInt32(textBox1.Text) - 1] == "")
                    {
                        // line null
                        lines[Convert.ToInt32(textBox1.Text) - 1] = richTextBox1.Text;
                        File.WriteAllLines(path, lines);
                        MessageBox.Show("Operations applied successfully!");
                        return;
                    }
                    else
                    {
                        // line not null, data cannot be written
                        MessageBox.Show("Data cannot be overwritten, line already present.");
                        return;
                    }
                }
                StreamWriter sw_append = new StreamWriter(path, true);
                for (int i = (lineCount + 1); i < Convert.ToInt32(textBox1.Text); i++)
                {
                    // keep writing empty lines over the file
                    sw_append.WriteLine("");
                }
                sw_append.WriteLine(richTextBox1.Text);
                sw_append.Close();
                MessageBox.Show("Operations applied successfully!");
                return;
            }

            // else append lines to the data of file
            // can use this if to append data to next line
            StreamWriter sw = new StreamWriter(path, true);
            sw.WriteLine(richTextBox1.Text);
            sw.Close();
            DialogResult r = MessageBox.Show("Operations applied successfully!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string path = "C:/Users/Pranav Jain/Desktop/Gate paper 2024/6th Semester/Prgm in Windows/demo-file.txt";
            if (!File.Exists(path))
            {
                MessageBox.Show("File does not exists");
                return;
            }
            StreamReader sr = new StreamReader(path);
            richTextBox1.Text = sr.ReadToEnd();
            sr.Close();
            DialogResult r = MessageBox.Show("Operations applied successfully!");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string path = "C:/Users/Pranav Jain/Desktop/Gate paper 2024/6th Semester/Prgm in Windows/demo-file.txt";
            File.Delete(path);
            MessageBox.Show("File successfully deleted");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string path = "C:/Users/Pranav Jain/Desktop/Gate paper 2024/6th Semester/Prgm in Windows/demo-file.txt";
            if(!File.Exists(path))
            {
                return;
            }
            int lineCount = File.ReadLines(path).Count();
            MessageBox.Show(lineCount.ToString());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string path = "C:/Users/Pranav Jain/Desktop/Gate paper 2024/6th Semester/Prgm in Windows/demo-file.txt";

            if (textBox1.Text.Length == 0)
            {
                // no input entered
                MessageBox.Show("No input. Please try again.");
                return;
            }

            if (!File.Exists(path))
            {
                return;
            }

            string[] lines = File.ReadAllLines(path);   // reading all lines of file
            int idx = Convert.ToInt32(textBox1.Text);
            lines[idx - 1] = ""; // deleting the line
            File.WriteAllLines(path, lines);
            MessageBox.Show("Operation applied successfully!");
        }
    }
}
