namespace File_operations_in_dotnet
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
            button_back = new Button();
            button_exit = new Button();
            label1 = new Label();
            label2 = new Label();
            textbox_filepath = new TextBox();
            label3 = new Label();
            richtextbox_filewrite = new RichTextBox();
            label4 = new Label();
            richtextbox_fileread = new RichTextBox();
            richtextbox_filesearch = new RichTextBox();
            label5 = new Label();
            button_write = new Button();
            button_read = new Button();
            button_find = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // button_back
            // 
            button_back.Dock = DockStyle.Bottom;
            button_back.Location = new Point(0, 421);
            button_back.Name = "button_back";
            button_back.Size = new Size(800, 29);
            button_back.TabIndex = 0;
            button_back.Text = "Back";
            button_back.UseVisualStyleBackColor = true;
            button_back.Click += button_back_Click;
            // 
            // button_exit
            // 
            button_exit.Dock = DockStyle.Bottom;
            button_exit.Location = new Point(0, 392);
            button_exit.Name = "button_exit";
            button_exit.Size = new Size(800, 29);
            button_exit.TabIndex = 1;
            button_exit.Text = "Exit";
            button_exit.UseVisualStyleBackColor = true;
            button_exit.Click += button_exit_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(183, 20);
            label1.Name = "label1";
            label1.Size = new Size(409, 35);
            label1.TabIndex = 2;
            label1.Text = "File Handling Application";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(215, 76);
            label2.Name = "label2";
            label2.Size = new Size(338, 18);
            label2.TabIndex = 3;
            label2.Text = "Enter your directory path and file name";
            // 
            // textbox_filepath
            // 
            textbox_filepath.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            textbox_filepath.Location = new Point(215, 118);
            textbox_filepath.Name = "textbox_filepath";
            textbox_filepath.Size = new Size(338, 27);
            textbox_filepath.TabIndex = 4;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(36, 197);
            label3.Name = "label3";
            label3.Size = new Size(202, 18);
            label3.TabIndex = 5;
            label3.Text = "Enter your file content";
            // 
            // richtextbox_filewrite
            // 
            richtextbox_filewrite.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            richtextbox_filewrite.Location = new Point(36, 244);
            richtextbox_filewrite.Name = "richtextbox_filewrite";
            richtextbox_filewrite.Size = new Size(223, 103);
            richtextbox_filewrite.TabIndex = 6;
            richtextbox_filewrite.Text = "";
            richtextbox_filewrite.WordWrap = false;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(263, 197);
            label4.Name = "label4";
            label4.Size = new Size(253, 18);
            label4.TabIndex = 7;
            label4.Text = "Read the existing file content";
            // 
            // richtextbox_fileread
            // 
            richtextbox_fileread.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            richtextbox_fileread.Location = new Point(295, 244);
            richtextbox_fileread.Name = "richtextbox_fileread";
            richtextbox_fileread.Size = new Size(223, 103);
            richtextbox_fileread.TabIndex = 8;
            richtextbox_fileread.Text = "";
            richtextbox_fileread.WordWrap = false;
            // 
            // richtextbox_filesearch
            // 
            richtextbox_filesearch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            richtextbox_filesearch.Location = new Point(549, 244);
            richtextbox_filesearch.Name = "richtextbox_filesearch";
            richtextbox_filesearch.Size = new Size(223, 103);
            richtextbox_filesearch.TabIndex = 10;
            richtextbox_filesearch.Text = "";
            richtextbox_filesearch.WordWrap = false;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label5.AutoSize = true;
            label5.Font = new Font("Showcard Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(549, 197);
            label5.Name = "label5";
            label5.Size = new Size(218, 18);
            label5.TabIndex = 9;
            label5.Text = "Find the words in the file";
            // 
            // button_write
            // 
            button_write.Anchor = AnchorStyles.Bottom;
            button_write.Location = new Point(91, 353);
            button_write.Name = "button_write";
            button_write.Size = new Size(104, 29);
            button_write.TabIndex = 11;
            button_write.Text = "Write";
            button_write.UseVisualStyleBackColor = true;
            button_write.Click += button_write_Click;
            // 
            // button_read
            // 
            button_read.Anchor = AnchorStyles.Bottom;
            button_read.Location = new Point(343, 353);
            button_read.Name = "button_read";
            button_read.Size = new Size(120, 29);
            button_read.TabIndex = 12;
            button_read.Text = "Read";
            button_read.UseVisualStyleBackColor = true;
            button_read.Click += button_read_Click;
            // 
            // button_find
            // 
            button_find.Anchor = AnchorStyles.Bottom;
            button_find.Location = new Point(604, 353);
            button_find.Name = "button_find";
            button_find.Size = new Size(119, 29);
            button_find.TabIndex = 13;
            button_find.Text = "Find";
            button_find.UseVisualStyleBackColor = true;
            button_find.Click += button_find_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom;
            button1.Location = new Point(616, 116);
            button1.Name = "button1";
            button1.Size = new Size(120, 29);
            button1.TabIndex = 14;
            button1.Text = "Continue";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(button_find);
            Controls.Add(button_read);
            Controls.Add(button_write);
            Controls.Add(richtextbox_filesearch);
            Controls.Add(label5);
            Controls.Add(richtextbox_fileread);
            Controls.Add(label4);
            Controls.Add(richtextbox_filewrite);
            Controls.Add(label3);
            Controls.Add(textbox_filepath);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button_exit);
            Controls.Add(button_back);
            Name = "Form2";
            Text = "Read, Write, Find from/into file";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_back;
        private Button button_exit;
        private Label label1;
        private Label label2;
        private TextBox textbox_filepath;
        private Label label3;
        private RichTextBox richtextbox_filewrite;
        private Label label4;
        private RichTextBox richtextbox_fileread;
        private RichTextBox richtextbox_filesearch;
        private Label label5;
        private Button button_write;
        private Button button_read;
        private Button button_find;
        private Button button1;
    }
}