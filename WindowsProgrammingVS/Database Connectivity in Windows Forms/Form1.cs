using System.Data.SqlClient;

namespace Database_Connectivity_in_Windows_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_database_Click(object sender, EventArgs e)
        {
            string Connectionstring = "Data Source=LAPTOP-NFJ7VAOT\\SQLEXPRESS;Initial Catalog=Pranav;Integrated Security=True;Connect Timeout=30;Encrypt=False"; // Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
            SqlConnection con = new SqlConnection(Connectionstring);
            con.Open();
            string name = textbox_name.Text;
            string course = textbox_course.Text;
            string Query = "INSERT INTO MyFirstTable(NAME, COURSE) VALUES('" + name + "', '" + course + "')";
            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Saved Successfully");
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_restart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
