namespace File_operations_in_dotnet
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
            button1 = new Button();
            button2 = new Button();
            richTextBox1 = new RichTextBox();
            button_continue = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(327, 267);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Create File";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(441, 265);
            button2.Name = "button2";
            button2.Size = new Size(94, 32);
            button2.TabIndex = 1;
            button2.Text = "Exit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richTextBox1.Location = new Point(216, 47);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(415, 195);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // button_continue
            // 
            button_continue.Location = new Point(381, 316);
            button_continue.Name = "button_continue";
            button_continue.Size = new Size(94, 29);
            button_continue.TabIndex = 3;
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
            Controls.Add(richTextBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private RichTextBox richTextBox1;
        private Button button_continue;
    }
}
