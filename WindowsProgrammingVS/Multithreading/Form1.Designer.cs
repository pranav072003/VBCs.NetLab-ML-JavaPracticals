namespace Multithreading_Programming_in_Windows
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
            button_multithread = new Button();
            outputTextBox = new TextBox();
            button_exit = new Button();
            SuspendLayout();
            // 
            // button_multithread
            // 
            button_multithread.Location = new Point(247, 161);
            button_multithread.Name = "button_multithread";
            button_multithread.Size = new Size(233, 29);
            button_multithread.TabIndex = 0;
            button_multithread.Text = "Output Multithreading";
            button_multithread.UseVisualStyleBackColor = true;
            button_multithread.Click += button_multithread_Click;
            // 
            // outputTextBox
            // 
            outputTextBox.Location = new Point(191, 93);
            outputTextBox.Name = "outputTextBox";
            outputTextBox.Size = new Size(349, 27);
            outputTextBox.TabIndex = 1;
            // 
            // button_exit
            // 
            button_exit.Location = new Point(247, 212);
            button_exit.Name = "button_exit";
            button_exit.Size = new Size(233, 29);
            button_exit.TabIndex = 2;
            button_exit.Text = "Exit";
            button_exit.UseVisualStyleBackColor = true;
            button_exit.Click += button_exit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_exit);
            Controls.Add(outputTextBox);
            Controls.Add(button_multithread);
            Name = "Form1";
            Text = "Multithreading Demo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_multithread;
        private TextBox outputTextBox;
        private Button button_exit;
    }
}