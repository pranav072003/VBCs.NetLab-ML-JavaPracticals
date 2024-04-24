using System.Data.SqlClient;

namespace Database_Connectivity_in_Windows_Forms
{
    public partial class Form1 : Form
    {
        // creating three strings for dept, course
        public string dept = "";
        public string course = "";
        public string[] original_collection_list;  // original list items stored in listbox

        public Form1()
        {
            InitializeComponent();
        }

        private void button_database_Click(object sender, EventArgs e)
        {
            // Create a form with multiple fields as given in the SSMS file for SQL server
            try
            {
                DialogResult d = MessageBox.Show("Are you sure you want to submit? No updates are allowed once the data has been submitted!","Alert",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
                if (d == DialogResult.No)
                {
                    // return and do not proceed with saving
                    return;
                }
                string Connectionstring = "Data Source=LAPTOP-NFJ7VAOT\\SQLEXPRESS;Initial Catalog=Pranav;Integrated Security=True;Connect Timeout=30;Encrypt=False"; // Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
                SqlConnection con = new SqlConnection(Connectionstring);
                con.Open();
                string name = textbox_name.Text;
                string enroll_id = textbox_course.Text;
                if (dept.Length == 0 || course.Length == 0)
                {
                    // close the database connection
                    MessageBox.Show("Entries cannot be made to database");
                    con.Close();
                    return;
                }

                // for ensuring no multiple entries for same enrollment numbers are made
                string find_query = "SELECT COUNT(*) from MyFirstTable where ENROLLMENT_NUM='" + enroll_id + "'";
                SqlCommand cmd_find = new SqlCommand(find_query, con);
                Int32 r = Convert.ToInt32(cmd_find.ExecuteScalar());
                if (r!=0)
                {
                    // entry already exists for the enrollment id
                    MessageBox.Show("Entry already exists for the current student!");
                    con.Close();
                    return;
                }

                MessageBox.Show(name + " " + enroll_id + " " + dept + " " + course);
                string Query = "INSERT INTO MyFirstTable(NAME,ENROLLMENT_NUM,DEPARTMENT,COURSE) VALUES('" + name + "', '" + enroll_id + "', '" + dept + "', '" + course + "')";
                SqlCommand cmd = new SqlCommand(Query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data Saved Successfully");
            }
            catch (SqlException ex)  // SqlException class for displaying the errors while resolving SQL queries
            {
                // print the exception message
                MessageBox.Show("Query resolution error! Entries not satisfying the database constraints!");
                return;
            }
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_restart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(button_database, "Click here to save data to database");
            t.SetToolTip(button_exit, "Click here to exit the application");
            t.SetToolTip(button_restart, "Click here to restart the application");
            t.SetToolTip(listbox_studentdetail, "Click here to select more details");
            t.SetToolTip(button_reset, "Click here to reset the settings");
            original_collection_list = new string[listbox_studentdetail.Items.Count];
            for (int i = 0; i < listbox_studentdetail.Items.Count; i++)
            {
                original_collection_list[i] = listbox_studentdetail.Items[i].ToString();
            }
        }

        private void listbox_studentdetail_SelectedIndexChanged(object sender, EventArgs e)
        {
            // check for definition of dept and course strings
            if (dept.Length != 0 && course.Length != 0)
            {
                MessageBox.Show("Please reset the listbox before proceeding...");
                return;
            }
            // create string for menu title of courses
            string courses = "Choose one of the courses";
            if (listbox_studentdetail.SelectedIndex == 0 || listbox_studentdetail.SelectedItems.Count > 1)
            {
                // return error
                MessageBox.Show("Navigation Error....");
                return;
            }
            if (listbox_studentdetail.Items[0] == "Following are the USSs. Choose one of them:-")
            {
                // put selected item into dept string
                dept = listbox_studentdetail.SelectedItem.ToString();

                // create list of subjects for each of the options
                string[] USICT = new string[] { "B.Tech", "M.Tech", "MCA", "Ph.D" };
                string[] USLLS = new string[] { "BA LLB", "BBA LLB", "LLM" };
                string[] USBAS = new string[] { "M.Tech (Engineering Physics)", "M.Tech (Nanoscience and Technology)", "Ph.D" };
                string[] USAP = new string[] { "B.Arch", "M.Arch", "M.Plan", "Ph.D" };

                // based on the options selected create new menu
                if (listbox_studentdetail.SelectedIndex == 1)
                {
                    // USICT
                    listbox_studentdetail.Items.Clear();
                    listbox_studentdetail.Items.Add(courses);
                    for (int i = 0; i < USICT.Length; i++)
                    {
                        listbox_studentdetail.Items.Add(USICT[i]);
                    }
                }
                else if (listbox_studentdetail.SelectedIndex == 2)
                {
                    // USLLS
                    listbox_studentdetail.Items.Clear();
                    listbox_studentdetail.Items.Add(courses);
                    for (int i = 0; i < USLLS.Length; i++)
                    {
                        listbox_studentdetail.Items.Add(USLLS[i]);
                    }
                }
                else if (listbox_studentdetail.SelectedIndex == 3)
                {
                    // USBAS
                    listbox_studentdetail.Items.Clear();
                    listbox_studentdetail.Items.Add(courses);
                    for (int i = 0; i < USBAS.Length; i++)
                    {
                        listbox_studentdetail.Items.Add(USBAS[i]);
                    }
                }
                else
                {
                    // USAP
                    listbox_studentdetail.Items.Clear();
                    listbox_studentdetail.Items.Add(courses);
                    for (int i = 0; i < USAP.Length; i++)
                    {
                        listbox_studentdetail.Items.Add(USAP[i]);
                    }
                }
            }
            else if (listbox_studentdetail.Items[0] == courses)
            {
                // put selected item into course string
                course = listbox_studentdetail.SelectedItem.ToString();
                // reset listbox to original list of items
                listbox_studentdetail.Items.Clear();
                for (int i = 0; i < original_collection_list.Length; i++)
                {
                    listbox_studentdetail.Items.Add(original_collection_list[i]);
                }
                MessageBox.Show("Student Department: " + dept + ",Course Enrolled into: " + course);
            }
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            listbox_studentdetail.Items.Clear();
            textbox_course.Clear();
            textbox_course.Focus();
            textbox_name.Clear();
            textbox_name.Focus();
            for(int i=0;i<original_collection_list.Length;i++)
            {
                listbox_studentdetail.Items.Add(original_collection_list[i]);
            }
        }
    }
}
