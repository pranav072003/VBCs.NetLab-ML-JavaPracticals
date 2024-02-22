namespace Programming_in_Windows_Practical_1
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
            label_hi = new Label();
            button_select = new Button();
            button_cancel = new Button();
            button_logout = new Button();
            button_continue = new Button();
            SuspendLayout();
            // 
            // label_hi
            // 
            label_hi.AutoSize = true;
            label_hi.Font = new Font("Impact", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_hi.Location = new Point(108, 158);
            label_hi.Name = "label_hi";
            label_hi.Size = new Size(97, 75);
            label_hi.TabIndex = 0;
            label_hi.Text = "Hi!";
            // 
            // button_select
            // 
            button_select.Location = new Point(486, 158);
            button_select.Name = "button_select";
            button_select.Size = new Size(94, 29);
            button_select.TabIndex = 1;
            button_select.Text = "Select";
            button_select.UseVisualStyleBackColor = true;
            button_select.Click += button_select_Click;
            // 
            // button_cancel
            // 
            button_cancel.Location = new Point(486, 211);
            button_cancel.Name = "button_cancel";
            button_cancel.Size = new Size(94, 29);
            button_cancel.TabIndex = 2;
            button_cancel.Text = "Cancel";
            button_cancel.UseVisualStyleBackColor = true;
            button_cancel.Click += button_cancel_Click;
            // 
            // button_logout
            // 
            button_logout.Location = new Point(652, 158);
            button_logout.Name = "button_logout";
            button_logout.Size = new Size(94, 29);
            button_logout.TabIndex = 3;
            button_logout.Text = "Logout";
            button_logout.UseVisualStyleBackColor = true;
            button_logout.Click += button_logout_Click;
            // 
            // button_continue
            // 
            button_continue.Location = new Point(652, 211);
            button_continue.Name = "button_continue";
            button_continue.Size = new Size(94, 29);
            button_continue.TabIndex = 4;
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
            Controls.Add(button_logout);
            Controls.Add(button_cancel);
            Controls.Add(button_select);
            Controls.Add(label_hi);
            Name = "Form1";
            Text = "Home Page";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_hi;
        private Button button_select;
        private Button button_cancel;
        private Button button_logout;
        private Button button_continue;
    }
}