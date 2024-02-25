namespace Assignment_3_Windows_Programming_theory
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
            label1 = new Label();
            label_dob = new Label();
            date_birth = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            button_continue = new Button();
            button_back = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(154, 111);
            label1.Name = "label1";
            label1.Size = new Size(525, 35);
            label1.TabIndex = 0;
            label1.Text = "Click here to view status of your login details";
            label1.Click += label1_Click;
            // 
            // label_dob
            // 
            label_dob.AutoSize = true;
            label_dob.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_dob.Location = new Point(198, 189);
            label_dob.Name = "label_dob";
            label_dob.Size = new Size(125, 27);
            label_dob.TabIndex = 2;
            label_dob.Text = "Date of Birth:-";
            // 
            // date_birth
            // 
            date_birth.Location = new Point(343, 189);
            date_birth.MaxDate = new DateTime(2005, 7, 7, 0, 0, 0, 0);
            date_birth.MinDate = new DateTime(1991, 1, 1, 0, 0, 0, 0);
            date_birth.Name = "date_birth";
            date_birth.Size = new Size(250, 27);
            date_birth.TabIndex = 3;
            date_birth.Value = new DateTime(2005, 7, 7, 0, 0, 0, 0);
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(343, 240);
            dateTimePicker1.MaxDate = new DateTime(2024, 2, 25, 0, 0, 0, 0);
            dateTimePicker1.MinDate = new DateTime(2021, 1, 1, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 5;
            dateTimePicker1.Value = new DateTime(2021, 1, 1, 0, 0, 0, 0);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(198, 240);
            label2.Name = "label2";
            label2.Size = new Size(144, 27);
            label2.TabIndex = 4;
            label2.Text = "Date of Joining:-";
            // 
            // button_continue
            // 
            button_continue.Location = new Point(248, 315);
            button_continue.Name = "button_continue";
            button_continue.Size = new Size(94, 29);
            button_continue.TabIndex = 6;
            button_continue.Text = "Continue";
            button_continue.UseVisualStyleBackColor = true;
            button_continue.Click += button_continue_Click;
            // 
            // button_back
            // 
            button_back.Location = new Point(424, 315);
            button_back.Name = "button_back";
            button_back.Size = new Size(94, 29);
            button_back.TabIndex = 7;
            button_back.Text = "Back";
            button_back.UseVisualStyleBackColor = true;
            button_back.Click += button_back_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_back);
            Controls.Add(button_continue);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(date_birth);
            Controls.Add(label_dob);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Mid Registration Page";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label_dob;
        private DateTimePicker date_birth;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private Button button_continue;
        private Button button_back;
    }
}