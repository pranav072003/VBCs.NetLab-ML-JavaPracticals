namespace Programming_in_Windows_Practical_2
{
    public partial class Form1 : Form
    {
        public static string Fname;
        public static string Lname;
        public static string Email;
        public static Boolean sms;
        public static Boolean reports;
        public static Boolean transactions;
        Form2 f = new Form2();

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // written by mistake. Ignore it
        }

        private void button_signup_Click(object sender, EventArgs e)
        {
            Fname = textbox_fname.Text;
            Lname = textbox_lname.Text;
            Email = textbox_emailid.Text;
            this.Hide();
            // Form2 f = new Form2();
            f.Show();
        }

        private void checkbox_sms_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox_sms.Checked)
            {
                sms = true;
                label_smsinfo.Text = "Service Charges may apply.";
            }
            else
            {
                sms = false;
                label_smsinfo.Text = "...";
            }
        }

        private void checkbox_reports_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox_reports.Checked)
            {
                reports = true;
            }
            else
            {
                reports = false;
            }
        }

        private void checkbox_transaction_CheckedChanged(object sender, EventArgs e)
        {
            if(checkbox_transaction.Checked)
            {
                transactions = true;
                label_transactioninfo.Text = "Service charges may apply.";
            }
            else
            {
                transactions= false;
                label_transactioninfo.Text = "...";
            }
        }
    }
}
