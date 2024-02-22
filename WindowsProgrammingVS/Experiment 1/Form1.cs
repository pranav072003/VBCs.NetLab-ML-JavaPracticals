namespace WinFormsApppracticalexp1
{
    public partial class MyWinApp : Form
    {
        public MyWinApp()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbl1.Text = "We are cancelling......";
        }

        private void button_set_Click(object sender, EventArgs e)
        {
            lbl1.Text = "Hello World again.......";
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }
    }
}
