namespace UIResponsiveness_PrgmInWindows
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
            textbox_userid = new TextBox();
            textbox_password = new TextBox();
            label2 = new Label();
            button_login = new Button();
            button_back = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(193, 93);
            label1.Name = "label1";
            label1.Size = new Size(92, 28);
            label1.TabIndex = 0;
            label1.Text = "User ID:-";
            // 
            // textbox_userid
            // 
            textbox_userid.Location = new Point(358, 93);
            textbox_userid.Name = "textbox_userid";
            textbox_userid.Size = new Size(285, 27);
            textbox_userid.TabIndex = 1;
            // 
            // textbox_password
            // 
            textbox_password.Location = new Point(358, 149);
            textbox_password.MaxLength = 8;
            textbox_password.Name = "textbox_password";
            textbox_password.Size = new Size(285, 27);
            textbox_password.TabIndex = 3;
            textbox_password.UseSystemPasswordChar = true;
            textbox_password.TextChanged += textbox_password_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(193, 149);
            label2.Name = "label2";
            label2.Size = new Size(117, 28);
            label2.TabIndex = 2;
            label2.Text = "Password:-";
            // 
            // button_login
            // 
            button_login.Location = new Point(280, 226);
            button_login.Name = "button_login";
            button_login.Size = new Size(94, 29);
            button_login.TabIndex = 4;
            button_login.Text = "Login";
            button_login.UseVisualStyleBackColor = true;
            button_login.Click += button_login_Click;
            // 
            // button_back
            // 
            button_back.Location = new Point(402, 226);
            button_back.Name = "button_back";
            button_back.Size = new Size(94, 29);
            button_back.TabIndex = 5;
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
            Controls.Add(button_login);
            Controls.Add(textbox_password);
            Controls.Add(label2);
            Controls.Add(textbox_userid);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Login Page";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textbox_userid;
        private TextBox textbox_password;
        private Label label2;
        private Button button_login;
        private Button button_back;
    }
}