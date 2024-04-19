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
            SuspendLayout();
            // 
            // textbox_name
            // 
            textbox_name.Anchor = AnchorStyles.Bottom;
            textbox_name.Location = new Point(345, 104);
            textbox_name.Name = "textbox_name";
            textbox_name.Size = new Size(270, 27);
            textbox_name.TabIndex = 1;
            // 
            // textbox_course
            // 
            textbox_course.Anchor = AnchorStyles.Bottom;
            textbox_course.Location = new Point(345, 161);
            textbox_course.Name = "textbox_course";
            textbox_course.Size = new Size(270, 27);
            textbox_course.TabIndex = 3;
            // 
            // button_database
            // 
            button_database.Anchor = AnchorStyles.Bottom;
            button_database.Location = new Point(345, 240);
            button_database.Name = "button_database";
            button_database.Size = new Size(200, 29);
            button_database.TabIndex = 4;
            button_database.Text = "Save to database";
            button_database.UseVisualStyleBackColor = true;
            button_database.Click += button_database_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Location = new Point(229, 104);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 5;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Location = new Point(229, 161);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 6;
            label2.Text = "Course";
            // 
            // button_exit
            // 
            button_exit.Anchor = AnchorStyles.Bottom;
            button_exit.Location = new Point(345, 292);
            button_exit.Name = "button_exit";
            button_exit.Size = new Size(200, 29);
            button_exit.TabIndex = 7;
            button_exit.Text = "Exit";
            button_exit.UseVisualStyleBackColor = true;
            button_exit.Click += button_exit_Click;
            // 
            // button_restart
            // 
            button_restart.Anchor = AnchorStyles.Bottom;
            button_restart.Location = new Point(345, 346);
            button_restart.Name = "button_restart";
            button_restart.Size = new Size(200, 29);
            button_restart.TabIndex = 8;
            button_restart.Text = "Restart";
            button_restart.UseVisualStyleBackColor = true;
            button_restart.Click += button_restart_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_restart);
            Controls.Add(button_exit);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button_database);
            Controls.Add(textbox_course);
            Controls.Add(textbox_name);
            Name = "Form1";
            Text = "Database Connectivity";
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
    }
}
