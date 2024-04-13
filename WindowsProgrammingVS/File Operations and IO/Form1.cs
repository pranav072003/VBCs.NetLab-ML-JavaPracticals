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
            string folder_path = "C:/Users/Pranav Jain/Desktop/Gate paper 2024/6th Semester/Prgm in Windows/demo-folder";
            if (File.Exists(path))
            {
                // check whether a file with the same path already exists or not
                DialogResult result = MessageBox.Show("File already exists!");
            }
            if (!Directory.Exists(folder_path))
            {
                // check whether a folder with name does not exists or not
                Directory.CreateDirectory(folder_path);
            }

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

            string file_folder_path = Path.Combine(folder_path, "demo-file.txt");
            File.Create(file_folder_path).Close(); // create a file and close it immediately
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
    }
}
