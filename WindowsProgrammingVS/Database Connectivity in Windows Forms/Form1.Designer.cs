namespace Database_Connectivity_in_Windows_Forms
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
            textbox_name = new TextBox();
            textbox_course = new TextBox();
            button_database = new Button();
            label1 = new Label();
            label2 = new Label();
            button_exit = new Button();
            button_restart = new Button();
            label4 = new Label();
            listbox_studentdetail = new ListBox();
            button_reset = new Button();
            button_databaseupdate = new Button();
            button_loaddata = new Button();
            button_deletedatabase = new Button();
            dataGridView_database = new DataGridView();
            button_continue = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView_database).BeginInit();
            SuspendLayout();
            // 
            // textbox_name
            // 
            textbox_name.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            textbox_name.Location = new Point(211, 104);
            textbox_name.Name = "textbox_name";
            textbox_name.Size = new Size(270, 27);
            textbox_name.TabIndex = 1;
            // 
            // textbox_course
            // 
            textbox_course.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            textbox_course.Location = new Point(211, 162);
            textbox_course.Name = "textbox_course";
            textbox_course.Size = new Size(270, 27);
            textbox_course.TabIndex = 3;
            // 
            // button_database
            // 
            button_database.Anchor = AnchorStyles.Top;
            button_database.Location = new Point(522, 104);
            button_database.Name = "button_database";
            button_database.Size = new Size(200, 29);
            button_database.TabIndex = 4;
            button_database.Text = "Save to database";
            button_database.UseVisualStyleBackColor = true;
            button_database.Click += button_database_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Location = new Point(89, 104);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 5;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Location = new Point(51, 160);
            label2.Name = "label2";
            label2.Size = new Size(139, 20);
            label2.TabIndex = 6;
            label2.Text = "Enrollment Number";
            // 
            // button_exit
            // 
            button_exit.Anchor = AnchorStyles.Top;
            button_exit.Location = new Point(522, 160);
            button_exit.Name = "button_exit";
            button_exit.Size = new Size(200, 29);
            button_exit.TabIndex = 7;
            button_exit.Text = "Exit";
            button_exit.UseVisualStyleBackColor = true;
            button_exit.Click += button_exit_Click;
            // 
            // button_restart
            // 
            button_restart.Anchor = AnchorStyles.Top;
            button_restart.Location = new Point(522, 218);
            button_restart.Name = "button_restart";
            button_restart.Size = new Size(200, 29);
            button_restart.TabIndex = 8;
            button_restart.Text = "Restart";
            button_restart.UseVisualStyleBackColor = true;
            button_restart.Click += button_restart_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(154, 37);
            label4.Name = "label4";
            label4.Size = new Size(468, 29);
            label4.TabIndex = 10;
            label4.Text = "Student Database Registration Form";
            // 
            // listbox_studentdetail
            // 
            listbox_studentdetail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            listbox_studentdetail.FormattingEnabled = true;
            listbox_studentdetail.Items.AddRange(new object[] { "Following are the USSs. Choose one of them:-", "USICT", "USLLS", "USBAS", "USAP" });
            listbox_studentdetail.Location = new Point(115, 218);
            listbox_studentdetail.Name = "listbox_studentdetail";
            listbox_studentdetail.Size = new Size(335, 84);
            listbox_studentdetail.TabIndex = 13;
            listbox_studentdetail.SelectedIndexChanged += listbox_studentdetail_SelectedIndexChanged;
            // 
            // button_reset
            // 
            button_reset.Anchor = AnchorStyles.Top;
            button_reset.Location = new Point(522, 270);
            button_reset.Name = "button_reset";
            button_reset.Size = new Size(200, 29);
            button_reset.TabIndex = 14;
            button_reset.Text = "Reset ";
            button_reset.UseVisualStyleBackColor = true;
            button_reset.Click += button_reset_Click;
            // 
            // button_databaseupdate
            // 
            button_databaseupdate.Anchor = AnchorStyles.Top;
            button_databaseupdate.Location = new Point(522, 321);
            button_databaseupdate.Name = "button_databaseupdate";
            button_databaseupdate.Size = new Size(200, 29);
            button_databaseupdate.TabIndex = 15;
            button_databaseupdate.Text = "Update to database";
            button_databaseupdate.UseVisualStyleBackColor = true;
            button_databaseupdate.Click += button_databaseupdate_Click;
            // 
            // button_loaddata
            // 
            button_loaddata.Anchor = AnchorStyles.Top;
            button_loaddata.Location = new Point(522, 371);
            button_loaddata.Name = "button_loaddata";
            button_loaddata.Size = new Size(200, 29);
            button_loaddata.TabIndex = 16;
            button_loaddata.Text = "Load Data";
            button_loaddata.UseVisualStyleBackColor = true;
            button_loaddata.Click += button_loaddata_Click;
            // 
            // button_deletedatabase
            // 
            button_deletedatabase.Anchor = AnchorStyles.Top;
            button_deletedatabase.Location = new Point(522, 419);
            button_deletedatabase.Name = "button_deletedatabase";
            button_deletedatabase.Size = new Size(200, 29);
            button_deletedatabase.TabIndex = 17;
            button_deletedatabase.Text = "Delete from database";
            button_deletedatabase.UseVisualStyleBackColor = true;
            button_deletedatabase.Click += button_deletedatabase_Click;
            // 
            // dataGridView_database
            // 
            dataGridView_database.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_database.Location = new Point(51, 346);
            dataGridView_database.Name = "dataGridView_database";
            dataGridView_database.RowHeadersWidth = 51;
            dataGridView_database.Size = new Size(444, 77);
            dataGridView_database.TabIndex = 18;
            // 
            // button_continue
            // 
            button_continue.Anchor = AnchorStyles.Top;
            button_continue.Location = new Point(628, 37);
            button_continue.Name = "button_continue";
            button_continue.Size = new Size(160, 29);
            button_continue.TabIndex = 19;
            button_continue.Text = "Continue";
            button_continue.UseVisualStyleBackColor = true;
            button_continue.Click += button_continue_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_continue);
            Controls.Add(dataGridView_database);
            Controls.Add(button_deletedatabase);
            Controls.Add(button_loaddata);
            Controls.Add(button_databaseupdate);
            Controls.Add(button_reset);
            Controls.Add(listbox_studentdetail);
            Controls.Add(label4);
            Controls.Add(button_restart);
            Controls.Add(button_exit);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button_database);
            Controls.Add(textbox_course);
            Controls.Add(textbox_name);
            Name = "Form1";
            Text = "Database Connectivity";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_database).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textbox_name;
        private TextBox textbox_course;
        private Button button_database;
        private Label label1;
        private Label label2;
        private Button button_exit;
        private Button button_restart;
        private Label label4;
        private ListBox listbox_studentdetail;
        private Button button_reset;
        private Button button_databaseupdate;
        private Button button_loaddata;
        private Button button_deletedatabase;
        private DataGridView dataGridView_database;
        private Button button_continue;
    }
}
