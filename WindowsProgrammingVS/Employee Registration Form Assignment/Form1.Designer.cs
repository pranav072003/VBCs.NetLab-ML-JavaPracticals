namespace Assignment_3_Windows_Programming_theory
{
    partial class Form1
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
            label_name = new Label();
            textbox_name = new TextBox();
            textbox_empid = new TextBox();
            label_empid = new Label();
            button_continue = new Button();
            button_reset = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // label_name
            // 
            label_name.AutoSize = true;
            label_name.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_name.Location = new Point(214, 107);
            label_name.Name = "label_name";
            label_name.Size = new Size(73, 27);
            label_name.TabIndex = 0;
            label_name.Text = "Name:-";
            // 
            // textbox_name
            // 
            textbox_name.Location = new Point(346, 109);
            textbox_name.Name = "textbox_name";
            textbox_name.Size = new Size(203, 27);
            textbox_name.TabIndex = 1;
            // 
            // textbox_empid
            // 
            textbox_empid.Location = new Point(346, 156);
            textbox_empid.Name = "textbox_empid";
            textbox_empid.Size = new Size(203, 27);
            textbox_empid.TabIndex = 3;
            // 
            // label_empid
            // 
            label_empid.AutoSize = true;
            label_empid.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_empid.Location = new Point(179, 156);
            label_empid.Name = "label_empid";
            label_empid.Size = new Size(128, 27);
            label_empid.TabIndex = 2;
            label_empid.Text = "Employee ID:-";
            label_empid.Click += label1_Click;
            // 
            // button_continue
            // 
            button_continue.Location = new Point(243, 232);
            button_continue.Name = "button_continue";
            button_continue.Size = new Size(94, 29);
            button_continue.TabIndex = 4;
            button_continue.Text = "Continue";
            button_continue.UseVisualStyleBackColor = true;
            button_continue.Click += button_continue_Click;
            // 
            // button_reset
            // 
            button_reset.Location = new Point(393, 232);
            button_reset.Name = "button_reset";
            button_reset.Size = new Size(94, 29);
            button_reset.TabIndex = 5;
            button_reset.Text = "Reset";
            button_reset.UseVisualStyleBackColor = true;
            button_reset.Click += button_reset_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(56, 42);
            label1.Name = "label1";
            label1.Size = new Size(697, 25);
            label1.TabIndex = 6;
            label1.Text = "Welcome to Oscorp Ltd! If you are a fresh recruit, please get yourself registered!";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(button_reset);
            Controls.Add(button_continue);
            Controls.Add(textbox_empid);
            Controls.Add(label_empid);
            Controls.Add(textbox_name);
            Controls.Add(label_name);
            Name = "Form1";
            Text = "Home Page Registration Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_name;
        private TextBox textbox_name;
        private TextBox textbox_empid;
        private Label label_empid;
        private Button button_continue;
        private Button button_reset;
        private Label label1;
    }
}