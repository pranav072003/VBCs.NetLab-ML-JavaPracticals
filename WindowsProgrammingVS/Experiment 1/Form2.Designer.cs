namespace Programming_in_Windows_Practical_1
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
            button_reset = new Button();
            button_close = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(163, 111);
            label1.Name = "label1";
            label1.Size = new Size(80, 25);
            label1.TabIndex = 0;
            label1.Text = "User ID:-";
            // 
            // textbox_userid
            // 
            textbox_userid.Location = new Point(331, 111);
            textbox_userid.Name = "textbox_userid";
            textbox_userid.Size = new Size(278, 27);
            textbox_userid.TabIndex = 1;
            // 
            // textbox_password
            // 
            textbox_password.Location = new Point(331, 172);
            textbox_password.Name = "textbox_password";
            textbox_password.Size = new Size(278, 27);
            textbox_password.TabIndex = 3;
            textbox_password.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(163, 172);
            label2.Name = "label2";
            label2.Size = new Size(100, 25);
            label2.TabIndex = 2;
            label2.Text = "Password:-";
            // 
            // button_login
            // 
            button_login.Location = new Point(244, 259);
            button_login.Name = "button_login";
            button_login.Size = new Size(94, 29);
            button_login.TabIndex = 4;
            button_login.Text = "Login";
            button_login.UseVisualStyleBackColor = true;
            button_login.Click += button_login_Click;
            // 
            // button_reset
            // 
            button_reset.Location = new Point(417, 259);
            button_reset.Name = "button_reset";
            button_reset.Size = new Size(94, 29);
            button_reset.TabIndex = 5;
            button_reset.Text = "Reset";
            button_reset.UseVisualStyleBackColor = true;
            button_reset.Click += button_reset_Click;
            // 
            // button_close
            // 
            button_close.Location = new Point(331, 320);
            button_close.Name = "button_close";
            button_close.Size = new Size(94, 29);
            button_close.TabIndex = 6;
            button_close.Text = "Close";
            button_close.UseVisualStyleBackColor = true;
            button_close.Click += button_close_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_close);
            Controls.Add(button_reset);
            Controls.Add(button_login);
            Controls.Add(textbox_password);
            Controls.Add(label2);
            Controls.Add(textbox_userid);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Login Page";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textbox_userid;
        private TextBox textbox_password;
        private Label label2;
        private Button button_login;
        private Button button_reset;
        private Button button_close;
    }
}