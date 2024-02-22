namespace WinFormsApppracticalexp1
{
    partial class MyWinApp
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
            lbl1 = new Label();
            button_set = new Button();
            button_cancel = new Button();
            button_logout = new Button();
            SuspendLayout();
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Impact", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl1.Location = new Point(430, 151);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(97, 75);
            lbl1.TabIndex = 0;
            lbl1.Text = "Hi!";
            lbl1.Click += label1_Click;
            // 
            // button_set
            // 
            button_set.Location = new Point(433, 251);
            button_set.Name = "button_set";
            button_set.Size = new Size(94, 29);
            button_set.TabIndex = 1;
            button_set.Text = "Set";
            button_set.UseVisualStyleBackColor = true;
            button_set.Click += button_set_Click;
            // 
            // button_cancel
            // 
            button_cancel.Location = new Point(433, 303);
            button_cancel.Name = "button_cancel";
            button_cancel.Size = new Size(94, 29);
            button_cancel.TabIndex = 2;
            button_cancel.Text = "Cancel";
            button_cancel.UseVisualStyleBackColor = true;
            button_cancel.Click += button1_Click;
            // 
            // button_logout
            // 
            button_logout.Location = new Point(433, 358);
            button_logout.Name = "button_logout";
            button_logout.Size = new Size(94, 29);
            button_logout.TabIndex = 3;
            button_logout.Text = "Logout";
            button_logout.UseVisualStyleBackColor = true;
            button_logout.Click += button_logout_Click;
            // 
            // MyWinApp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_logout);
            Controls.Add(button_cancel);
            Controls.Add(button_set);
            Controls.Add(lbl1);
            Name = "MyWinApp";
            Text = "MyWinApp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1;
        private Button button_set;
        private Button button_cancel;
        private Button button_logout;
    }
}
