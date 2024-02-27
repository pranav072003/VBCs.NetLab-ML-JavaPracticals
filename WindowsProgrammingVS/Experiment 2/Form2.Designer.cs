namespace Programming_in_Windows_Practical_2
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label_confirmation = new Label();
            label_fname = new Label();
            label_confirmfname = new Label();
            label_lname = new Label();
            label_confirmlname = new Label();
            label_confirmid = new Label();
            label_emailid = new Label();
            groupbox_services = new GroupBox();
            label_sms = new Label();
            label_reports = new Label();
            label_transactions = new Label();
            label_smsenable = new Label();
            label_reportenable = new Label();
            label_transactionenable = new Label();
            groupbox_services.SuspendLayout();
            SuspendLayout();
            // 
            // label_confirmation
            // 
            label_confirmation.AutoSize = true;
            label_confirmation.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_confirmation.Location = new Point(237, 83);
            label_confirmation.Name = "label_confirmation";
            label_confirmation.Size = new Size(327, 37);
            label_confirmation.TabIndex = 0;
            label_confirmation.Text = "Thank You for Signing up!";
            // 
            // label_fname
            // 
            label_fname.AutoSize = true;
            label_fname.Font = new Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_fname.Location = new Point(177, 170);
            label_fname.Name = "label_fname";
            label_fname.Size = new Size(146, 33);
            label_fname.TabIndex = 1;
            label_fname.Text = "First Name:- ";
            // 
            // label_confirmfname
            // 
            label_confirmfname.AutoSize = true;
            label_confirmfname.Font = new Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_confirmfname.Location = new Point(329, 170);
            label_confirmfname.Name = "label_confirmfname";
            label_confirmfname.Size = new Size(180, 33);
            label_confirmfname.TabIndex = 2;
            label_confirmfname.Text = "Your First Name";
            // 
            // label_lname
            // 
            label_lname.AutoSize = true;
            label_lname.Font = new Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_lname.Location = new Point(177, 212);
            label_lname.Name = "label_lname";
            label_lname.Size = new Size(145, 33);
            label_lname.TabIndex = 3;
            label_lname.Text = "Last Name:- ";
            // 
            // label_confirmlname
            // 
            label_confirmlname.AutoSize = true;
            label_confirmlname.Font = new Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_confirmlname.Location = new Point(329, 212);
            label_confirmlname.Name = "label_confirmlname";
            label_confirmlname.Size = new Size(179, 33);
            label_confirmlname.TabIndex = 4;
            label_confirmlname.Text = "Your Last Name";
            // 
            // label_confirmid
            // 
            label_confirmid.AutoSize = true;
            label_confirmid.Font = new Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_confirmid.Location = new Point(329, 256);
            label_confirmid.Name = "label_confirmid";
            label_confirmid.Size = new Size(153, 33);
            label_confirmid.TabIndex = 6;
            label_confirmid.Text = "Your Email ID";
            // 
            // label_emailid
            // 
            label_emailid.AutoSize = true;
            label_emailid.Font = new Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_emailid.Location = new Point(177, 256);
            label_emailid.Name = "label_emailid";
            label_emailid.Size = new Size(119, 33);
            label_emailid.TabIndex = 5;
            label_emailid.Text = "Email ID:- ";
            // 
            // groupbox_services
            // 
            groupbox_services.Controls.Add(label_transactionenable);
            groupbox_services.Controls.Add(label_reportenable);
            groupbox_services.Controls.Add(label_smsenable);
            groupbox_services.Controls.Add(label_transactions);
            groupbox_services.Controls.Add(label_reports);
            groupbox_services.Controls.Add(label_sms);
            groupbox_services.Font = new Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupbox_services.Location = new Point(191, 314);
            groupbox_services.Name = "groupbox_services";
            groupbox_services.Size = new Size(410, 175);
            groupbox_services.TabIndex = 8;
            groupbox_services.TabStop = false;
            groupbox_services.Text = "Services you chose:-";
            // 
            // label_sms
            // 
            label_sms.AutoSize = true;
            label_sms.Font = new Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_sms.Location = new Point(72, 57);
            label_sms.Name = "label_sms";
            label_sms.Size = new Size(190, 33);
            label_sms.TabIndex = 3;
            label_sms.Text = "SMS Notifications";
            // 
            // label_reports
            // 
            label_reports.AutoSize = true;
            label_reports.Font = new Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_reports.Location = new Point(72, 102);
            label_reports.Name = "label_reports";
            label_reports.Size = new Size(96, 33);
            label_reports.TabIndex = 4;
            label_reports.Text = "Reports";
            // 
            // label_transactions
            // 
            label_transactions.AutoSize = true;
            label_transactions.Font = new Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_transactions.Location = new Point(72, 142);
            label_transactions.Name = "label_transactions";
            label_transactions.Size = new Size(219, 33);
            label_transactions.TabIndex = 5;
            label_transactions.Text = "Transaction Reports";
            // 
            // label_smsenable
            // 
            label_smsenable.AutoSize = true;
            label_smsenable.Location = new Point(299, 57);
            label_smsenable.Name = "label_smsenable";
            label_smsenable.Size = new Size(24, 33);
            label_smsenable.TabIndex = 6;
            label_smsenable.Text = "*";
            // 
            // label_reportenable
            // 
            label_reportenable.AutoSize = true;
            label_reportenable.Location = new Point(297, 102);
            label_reportenable.Name = "label_reportenable";
            label_reportenable.Size = new Size(24, 33);
            label_reportenable.TabIndex = 7;
            label_reportenable.Text = "*";
            // 
            // label_transactionenable
            // 
            label_transactionenable.AutoSize = true;
            label_transactionenable.Location = new Point(299, 142);
            label_transactionenable.Name = "label_transactionenable";
            label_transactionenable.Size = new Size(24, 33);
            label_transactionenable.TabIndex = 8;
            label_transactionenable.Text = "*";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(800, 450);
            Controls.Add(groupbox_services);
            Controls.Add(label_confirmid);
            Controls.Add(label_emailid);
            Controls.Add(label_confirmlname);
            Controls.Add(label_lname);
            Controls.Add(label_confirmfname);
            Controls.Add(label_fname);
            Controls.Add(label_confirmation);
            Name = "Form2";
            Text = "Confirmation Form";
            Load += Form2_Load;
            groupbox_services.ResumeLayout(false);
            groupbox_services.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_confirmation;
        private Label label_fname;
        private Label label_confirmfname;
        private Label label_lname;
        private Label label_confirmlname;
        private Label label_confirmid;
        private Label label_emailid;
        private GroupBox groupbox_services;
        private Label label_sms;
        private Label label_reports;
        private Label label_transactions;
        private Label label_transactionenable;
        private Label label_reportenable;
        private Label label_smsenable;
    }
}