using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database_Connectivity_in_Windows_Forms
{
    public partial class Form2 : Form
    {
        public string dept = "";
        public string post = "";
        public string[] original_collection_list;

        public Form2()
        {
            InitializeComponent();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            original_collection_list = new string[listbox_empdetail.Items.Count];
            for (int i = 0; i < listbox_empdetail.Items.Count; i++)
            {
                original_collection_list[i] = listbox_empdetail.Items[i].ToString();
            }
        }

        private void button_savedatabase_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d = MessageBox.Show("Are you sure you want to submit? No updates are allowed once the data has been submitted!", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (d == DialogResult.No)
                {
                    // return and do not proceed with saving
                    return;
                }
                string Connectionstring = "Data Source=LAPTOP-NFJ7VAOT\\SQLEXPRESS;Initial Catalog=Pranav;Integrated Security=True;Connect Timeout=30;Encrypt=False"; // Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
                SqlConnection con = new SqlConnection(Connectionstring);
                con.Open();
                string name = textbox_name.Text;
                string emp_id = textbox_empid.Text;
                if (dept.Length == 0 || post.Length == 0)
                {
                    // close the database connection
                    MessageBox.Show("Entries cannot be made to database");
                    con.Close();
                    return;
                }

                MessageBox.Show(name + " " + emp_id + " " + dept + " " + post);
                string Query = "INSERT INTO EmployeeData(NAME,EMPLOYEE_ID,DEPARTMENT,POST) VALUES('" + name + "', '" + emp_id + "', '" + dept + "', '" + post + "')";
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

        private void listbox_empdetail_SelectedIndexChanged(object sender, EventArgs e)
        {
            string posts = "Choose one of the posts";
            if (listbox_empdetail.SelectedIndex == 0 || listbox_empdetail.SelectedItems.Count > 1)
            {
                // return error
                MessageBox.Show("Navigation Error....");
                return;
            }
            if (listbox_empdetail.Items[0] == "Following are the departments. Choose one of them:-")
            {
                // put selected item into dept string
                dept = listbox_empdetail.SelectedItem.ToString();

                // create list of posts for each of the options
                string[] IT = new string[] { "Scrum Manager", "Project Manager", "System Analyst", "Senior Programmer", "Junior Programmer" };
                string[] PR = new string[] { "Team Lead", "Senior Correspondent", "POC" };
                string[] Sales = new string[] { "Digital Marketing Head", "Area Sales Head", "Salesperson" };

                // based on the options selected create new menu
                if (listbox_empdetail.SelectedIndex == 1)
                {
                    // IT
                    listbox_empdetail.Items.Clear();
                    listbox_empdetail.Items.Add(posts);
                    for (int i = 0; i < IT.Length; i++)
                    {
                        listbox_empdetail.Items.Add(IT[i]);
                    }
                }
                else if (listbox_empdetail.SelectedIndex == 2)
                {
                    // PR
                    listbox_empdetail.Items.Clear();
                    listbox_empdetail.Items.Add(posts);
                    for (int i = 0; i < PR.Length; i++)
                    {
                        listbox_empdetail.Items.Add(PR[i]);
                    }
                }
                else
                {
                    // Sales and Marketing
                    listbox_empdetail.Items.Clear();
                    listbox_empdetail.Items.Add(posts);
                    for (int i = 0; i < Sales.Length; i++)
                    {
                        listbox_empdetail.Items.Add(Sales[i]);
                    }
                }
            }
            else if (listbox_empdetail.Items[0] == posts)
            {
                // put selected item into course string
                post = listbox_empdetail.SelectedItem.ToString();
                // reset listbox to original list of items
                listbox_empdetail.Items.Clear();
                for (int i = 0; i < original_collection_list.Length; i++)
                {
                    listbox_empdetail.Items.Add(original_collection_list[i]);
                }
                MessageBox.Show("Employee Department: " + dept + ",Post: " + post);
            }
        }

        private void button_updatedatabase_Click(object sender, EventArgs e)
        {
            string emp_id = textbox_empid.Text;
            string name = textbox_name.Text;
            try
            {
                if (emp_id.Length == 0)
                {
                    // don't proceed with update
                    MessageBox.Show("Search field empty! Try again!");
                    return;
                }
                string Connectionstring = "Data Source=LAPTOP-NFJ7VAOT\\SQLEXPRESS;Initial Catalog=Pranav;Integrated Security=True;Connect Timeout=30;Encrypt=False"; // Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
                SqlConnection con = new SqlConnection(Connectionstring);
                con.Open();
                // updates the row having entry for student
                string update_query = "UPDATE EmployeeData SET NAME='" + name + "', DEPARTMENT='" + dept + "', POST='" + post + "' WHERE EMPLOYEE_ID='" + emp_id + "'";
                SqlCommand update_data = new SqlCommand(update_query, con);
                update_data.ExecuteNonQuery();
                MessageBox.Show("Update into Data successful!");
                con.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Update into Data unsuccessful!");
            }
        }

        private void button_loaddata_Click(object sender, EventArgs e)
        {
            try
            {
                // Create a connection to the database
                string Connectionstring = "Data Source=LAPTOP-NFJ7VAOT\\SQLEXPRESS;Initial Catalog=Pranav;Integrated Security=True;Connect Timeout=30;Encrypt=False"; // Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
                using (SqlConnection connection = new SqlConnection(Connectionstring))
                {
                    // Open the connection
                    connection.Open();

                    // SQL query to select data from MyTable
                    string query = "SELECT * FROM EmployeeData";

                    // Create a data adapter
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        // Create a DataTable to hold the data
                        DataTable dataTable = new DataTable();
                        // DataGridView dataGridView = new DataGridView();

                        // Fill the DataTable with data from the database
                        adapter.Fill(dataTable);

                        // Bind the DataTable to a DataGridView control
                        dataGridView_emp.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
