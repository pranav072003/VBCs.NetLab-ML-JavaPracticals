namespace Database_Connectivity_in_Windows_Forms
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
            button_exit = new Button();
            button_savedatabase = new Button();
            button_updatedatabase = new Button();
            button_loaddata = new Button();
            label4 = new Label();
            listbox_empdetail = new ListBox();
            label2 = new Label();
            label1 = new Label();
            textbox_empid = new TextBox();
            textbox_name = new TextBox();
            dataGridView_emp = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView_emp).BeginInit();
            SuspendLayout();
            // 
            // button_exit
            // 
            button_exit.Anchor = AnchorStyles.Top;
            button_exit.Location = new Point(554, 73);
            button_exit.Name = "button_exit";
            button_exit.Size = new Size(160, 29);
            button_exit.TabIndex = 20;
            button_exit.Text = "Exit";
            button_exit.UseVisualStyleBackColor = true;
            button_exit.Click += button_exit_Click;
            // 
            // button_savedatabase
            // 
            button_savedatabase.Anchor = AnchorStyles.Top;
            button_savedatabase.Location = new Point(554, 140);
            button_savedatabase.Name = "button_savedatabase";
            button_savedatabase.Size = new Size(160, 29);
            button_savedatabase.TabIndex = 21;
            button_savedatabase.Text = "Save to Database";
            button_savedatabase.UseVisualStyleBackColor = true;
            button_savedatabase.Click += button_savedatabase_Click;
            // 
            // button_updatedatabase
            // 
            button_updatedatabase.Anchor = AnchorStyles.Top;
            button_updatedatabase.Location = new Point(554, 206);
            button_updatedatabase.Name = "button_updatedatabase";
            button_updatedatabase.Size = new Size(160, 29);
            button_updatedatabase.TabIndex = 22;
            button_updatedatabase.Text = "Update to Database";
            button_updatedatabase.UseVisualStyleBackColor = true;
            button_updatedatabase.Click += button_updatedatabase_Click;
            // 
            // button_loaddata
            // 
            button_loaddata.Anchor = AnchorStyles.Top;
            button_loaddata.Location = new Point(554, 264);
            button_loaddata.Name = "button_loaddata";
            button_loaddata.Size = new Size(160, 29);
            button_loaddata.TabIndex = 23;
            button_loaddata.Text = "Load data";
            button_loaddata.UseVisualStyleBackColor = true;
            button_loaddata.Click += button_loaddata_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(230, 28);
            label4.Name = "label4";
            label4.Size = new Size(368, 29);
            label4.TabIndex = 24;
            label4.Text = "Employee Registration Form";
            // 
            // listbox_empdetail
            // 
            listbox_empdetail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            listbox_empdetail.FormattingEnabled = true;
            listbox_empdetail.Items.AddRange(new object[] { "Following are the departments. Choose one of them:-", "IT Services", "Public Relations", "Sales and Marketing" });
            listbox_empdetail.Location = new Point(108, 187);
            listbox_empdetail.Name = "listbox_empdetail";
            listbox_empdetail.Size = new Size(372, 84);
            listbox_empdetail.TabIndex = 29;
            listbox_empdetail.SelectedIndexChanged += listbox_empdetail_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Location = new Point(96, 131);
            label2.Name = "label2";
            label2.Size = new Size(94, 20);
            label2.TabIndex = 28;
            label2.Text = "Employee ID";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Location = new Point(119, 73);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 27;
            label1.Text = "Name";
            // 
            // textbox_empid
            // 
            textbox_empid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            textbox_empid.Location = new Point(241, 131);
            textbox_empid.Name = "textbox_empid";
            textbox_empid.Size = new Size(270, 27);
            textbox_empid.TabIndex = 26;
            // 
            // textbox_name
            // 
            textbox_name.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            textbox_name.Location = new Point(241, 73);
            textbox_name.Name = "textbox_name";
            textbox_name.Size = new Size(270, 27);
            textbox_name.TabIndex = 25;
            // 
            // dataGridView_emp
            // 
            dataGridView_emp.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_emp.Location = new Point(79, 306);
            dataGridView_emp.Name = "dataGridView_emp";
            dataGridView_emp.RowHeadersWidth = 51;
            dataGridView_emp.Size = new Size(635, 132);
            dataGridView_emp.TabIndex = 30;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView_emp);
            Controls.Add(listbox_empdetail);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textbox_empid);
            Controls.Add(textbox_name);
            Controls.Add(label4);
            Controls.Add(button_loaddata);
            Controls.Add(button_updatedatabase);
            Controls.Add(button_savedatabase);
            Controls.Add(button_exit);
            Name = "Form2";
            Text = "Employee Database";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_emp).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_exit;
        private Button button_savedatabase;
        private Button button_updatedatabase;
        private Button button_loaddata;
        private Label label4;
        private ListBox listbox_empdetail;
        private Label label2;
        private Label label1;
        private TextBox textbox_empid;
        private TextBox textbox_name;
        private DataGridView dataGridView_emp;
    }
}