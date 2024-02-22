namespace WinFormsApppracticalexp1
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
            label_userid = new Label();
            textbox_userid = new TextBox();
            textbox_password = new TextBox();
            label_password = new Label();
            button_login = new Button();
            button_reset = new Button();
            SuspendLayout();
            // 
            // label_userid
            // 
            label_userid.AutoSize = true;
            label_userid.Font = new Font("Impact", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_userid.Location = new Point(236, 115);
            label_userid.Name = "label_userid";
            label_userid.Size = new Size(70, 22);
            label_userid.TabIndex = 0;
            label_userid.Text = "User ID:-";
            // 
            // textbox_userid
            // 
            textbox_userid.Location = new Point(351, 114);
            textbox_userid.Name = "textbox_userid";
            textbox_userid.Size = new Size(194, 27);
            textbox_userid.TabIndex = 1;
            // 
            // textbox_password
            // 
            textbox_password.Location = new Point(351, 167);
            textbox_password.Name = "textbox_password";
            textbox_password.Size = new Size(194, 27);
            textbox_password.TabIndex = 3;
            textbox_password.UseSystemPasswordChar = true;
            // 
            // label_password
            // 
            label_password.AutoSize = true;
            label_password.Font = new Font("Impact", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_password.Location = new Point(236, 168);
            label_password.Name = "label_password";
            label_password.Size = new Size(88, 22);
            label_password.TabIndex = 2;
            label_password.Text = "Password:-";
            // 
            // button_login
            // 
            button_login.Location = new Point(268, 241);
            button_login.Name = "button_login";
            button_login.Size = new Size(94, 29);
            button_login.TabIndex = 4;
            button_login.Text = "Login";
            button_login.UseVisualStyleBackColor = true;
            button_login.Click += button_login_Click;
            // 
            // button_reset
            // 
            button_reset.Location = new Point(423, 241);
            button_reset.Name = "button_reset";
            button_reset.Size = new Size(94, 29);
            button_reset.TabIndex = 5;
            button_reset.Text = "Reset";
            button_reset.UseVisualStyleBackColor = true;
            button_reset.Click += button_reset_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_reset);
            Controls.Add(button_login);
            Controls.Add(textbox_password);
            Controls.Add(label_password);
            Controls.Add(textbox_userid);
            Controls.Add(label_userid);
            Name = "Form2";
            Text = "Login Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_userid;
        private TextBox textbox_userid;
        private TextBox textbox_password;
        private Label label_password;
        private Button button_login;
        private Button button_reset;
    }
}