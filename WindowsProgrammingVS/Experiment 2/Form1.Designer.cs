namespace Programming_in_Windows_Practical_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label_fname = new Label();
            textbox_fname = new TextBox();
            textbox_lname = new TextBox();
            label_lname = new Label();
            textbox_emailid = new TextBox();
            label_emailid = new Label();
            groupbox_services = new GroupBox();
            label_transactioninfo = new Label();
            label_smsinfo = new Label();
            checkbox_transaction = new CheckBox();
            checkbox_reports = new CheckBox();
            checkbox_sms = new CheckBox();
            button_signup = new Button();
            groupbox_services.SuspendLayout();
            SuspendLayout();
            // 
            // label_fname
            // 
            label_fname.AutoSize = true;
            label_fname.Font = new Font("Impact", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_fname.Location = new Point(158, 98);
            label_fname.Name = "label_fname";
            label_fname.Size = new Size(149, 35);
            label_fname.TabIndex = 0;
            label_fname.Text = "First Name:-";
            // 
            // textbox_fname
            // 
            textbox_fname.Location = new Point(324, 98);
            textbox_fname.Name = "textbox_fname";
            textbox_fname.Size = new Size(259, 27);
            textbox_fname.TabIndex = 1;
            // 
            // textbox_lname
            // 
            textbox_lname.Location = new Point(324, 151);
            textbox_lname.Name = "textbox_lname";
            textbox_lname.Size = new Size(259, 27);
            textbox_lname.TabIndex = 3;
            // 
            // label_lname
            // 
            label_lname.AutoSize = true;
            label_lname.Font = new Font("Impact", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_lname.Location = new Point(158, 151);
            label_lname.Name = "label_lname";
            label_lname.Size = new Size(146, 35);
            label_lname.TabIndex = 2;
            label_lname.Text = "Last Name:-";
            label_lname.Click += label1_Click;
            // 
            // textbox_emailid
            // 
            textbox_emailid.Location = new Point(324, 208);
            textbox_emailid.Name = "textbox_emailid";
            textbox_emailid.Size = new Size(259, 27);
            textbox_emailid.TabIndex = 5;
            // 
            // label_emailid
            // 
            label_emailid.AutoSize = true;
            label_emailid.Font = new Font("Impact", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_emailid.Location = new Point(161, 208);
            label_emailid.Name = "label_emailid";
            label_emailid.Size = new Size(119, 35);
            label_emailid.TabIndex = 4;
            label_emailid.Text = "Email ID:-";
            // 
            // groupbox_services
            // 
            groupbox_services.Controls.Add(label_transactioninfo);
            groupbox_services.Controls.Add(label_smsinfo);
            groupbox_services.Controls.Add(checkbox_transaction);
            groupbox_services.Controls.Add(checkbox_reports);
            groupbox_services.Controls.Add(checkbox_sms);
            groupbox_services.Font = new Font("Impact", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupbox_services.Location = new Point(161, 272);
            groupbox_services.Name = "groupbox_services";
            groupbox_services.Size = new Size(468, 154);
            groupbox_services.TabIndex = 7;
            groupbox_services.TabStop = false;
            groupbox_services.Text = "Services";
            // 
            // label_transactioninfo
            // 
            label_transactioninfo.AutoSize = true;
            label_transactioninfo.Font = new Font("Arial Narrow", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_transactioninfo.Location = new Point(246, 117);
            label_transactioninfo.Name = "label_transactioninfo";
            label_transactioninfo.Size = new Size(22, 22);
            label_transactioninfo.TabIndex = 4;
            label_transactioninfo.Text = "...";
            // 
            // label_smsinfo
            // 
            label_smsinfo.AutoSize = true;
            label_smsinfo.Font = new Font("Arial Narrow", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_smsinfo.Location = new Point(246, 52);
            label_smsinfo.Name = "label_smsinfo";
            label_smsinfo.Size = new Size(22, 22);
            label_smsinfo.TabIndex = 3;
            label_smsinfo.Text = "...";
            // 
            // checkbox_transaction
            // 
            checkbox_transaction.AutoSize = true;
            checkbox_transaction.Font = new Font("Arial Narrow", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkbox_transaction.Location = new Point(69, 116);
            checkbox_transaction.Name = "checkbox_transaction";
            checkbox_transaction.Size = new Size(160, 26);
            checkbox_transaction.TabIndex = 2;
            checkbox_transaction.Text = "Transaction Reports";
            checkbox_transaction.UseVisualStyleBackColor = true;
            checkbox_transaction.CheckedChanged += checkbox_transaction_CheckedChanged;
            // 
            // checkbox_reports
            // 
            checkbox_reports.AutoSize = true;
            checkbox_reports.Font = new Font("Arial Narrow", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkbox_reports.Location = new Point(69, 84);
            checkbox_reports.Name = "checkbox_reports";
            checkbox_reports.Size = new Size(82, 26);
            checkbox_reports.TabIndex = 1;
            checkbox_reports.Text = "Reports";
            checkbox_reports.UseVisualStyleBackColor = true;
            checkbox_reports.CheckedChanged += checkbox_reports_CheckedChanged;
            // 
            // checkbox_sms
            // 
            checkbox_sms.AutoSize = true;
            checkbox_sms.Font = new Font("Arial Narrow", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkbox_sms.Location = new Point(69, 52);
            checkbox_sms.Name = "checkbox_sms";
            checkbox_sms.Size = new Size(144, 26);
            checkbox_sms.TabIndex = 0;
            checkbox_sms.Text = "SMS Notifications";
            checkbox_sms.UseVisualStyleBackColor = true;
            checkbox_sms.CheckedChanged += checkbox_sms_CheckedChanged;
            // 
            // button_signup
            // 
            button_signup.Location = new Point(592, 443);
            button_signup.Name = "button_signup";
            button_signup.Size = new Size(94, 29);
            button_signup.TabIndex = 8;
            button_signup.Text = "Sign Up";
            button_signup.UseVisualStyleBackColor = true;
            button_signup.Click += button_signup_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(800, 450);
            Controls.Add(button_signup);
            Controls.Add(groupbox_services);
            Controls.Add(textbox_emailid);
            Controls.Add(label_emailid);
            Controls.Add(textbox_lname);
            Controls.Add(label_lname);
            Controls.Add(textbox_fname);
            Controls.Add(label_fname);
            Name = "Form1";
            Text = "Sign Up Form";
            groupbox_services.ResumeLayout(false);
            groupbox_services.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_fname;
        private TextBox textbox_fname;
        private TextBox textbox_lname;
        private Label label_lname;
        private TextBox textbox_emailid;
        private Label label_emailid;
        private GroupBox groupbox_services;
        private CheckBox checkbox_sms;
        private CheckBox checkbox_reports;
        private CheckBox checkbox_transaction;
        private Label label_transactioninfo;
        private Label label_smsinfo;
        private Button button_signup;
    }
}
