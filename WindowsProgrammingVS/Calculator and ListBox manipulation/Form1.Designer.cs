namespace Assignment_4_Windows_Programming_theory
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
            label_welcome = new Label();
            label_input = new Label();
            textbox_input = new TextBox();
            listbox_input = new ListBox();
            button_add = new Button();
            button_remove = new Button();
            button_clear = new Button();
            button_continue = new Button();
            button_exit = new Button();
            SuspendLayout();
            // 
            // label_welcome
            // 
            label_welcome.AutoSize = true;
            label_welcome.Font = new Font("Arial Narrow", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label_welcome.Location = new Point(78, 79);
            label_welcome.Name = "label_welcome";
            label_welcome.Size = new Size(663, 27);
            label_welcome.TabIndex = 0;
            label_welcome.Text = "Welcome! Feel free to navigate throughout the form and interact with the controls";
            // 
            // label_input
            // 
            label_input.AutoSize = true;
            label_input.Font = new Font("Impact", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_input.Location = new Point(179, 170);
            label_input.Name = "label_input";
            label_input.Size = new Size(107, 28);
            label_input.TabIndex = 1;
            label_input.Text = "Your input";
            // 
            // textbox_input
            // 
            textbox_input.Location = new Point(371, 170);
            textbox_input.Name = "textbox_input";
            textbox_input.Size = new Size(254, 27);
            textbox_input.TabIndex = 2;
            // 
            // listbox_input
            // 
            listbox_input.FormattingEnabled = true;
            listbox_input.Location = new Point(179, 230);
            listbox_input.Name = "listbox_input";
            listbox_input.Size = new Size(446, 104);
            listbox_input.TabIndex = 3;
            // 
            // button_add
            // 
            button_add.Location = new Point(179, 370);
            button_add.Name = "button_add";
            button_add.Size = new Size(94, 29);
            button_add.TabIndex = 4;
            button_add.Text = "Add ";
            button_add.UseVisualStyleBackColor = true;
            button_add.Click += button_add_Click;
            // 
            // button_remove
            // 
            button_remove.Location = new Point(293, 370);
            button_remove.Name = "button_remove";
            button_remove.Size = new Size(94, 29);
            button_remove.TabIndex = 5;
            button_remove.Text = "Remove";
            button_remove.UseVisualStyleBackColor = true;
            button_remove.Click += button_remove_Click;
            // 
            // button_clear
            // 
            button_clear.Location = new Point(411, 370);
            button_clear.Name = "button_clear";
            button_clear.Size = new Size(94, 29);
            button_clear.TabIndex = 6;
            button_clear.Text = "Clear";
            button_clear.UseVisualStyleBackColor = true;
            button_clear.Click += button_clear_Click;
            // 
            // button_continue
            // 
            button_continue.Location = new Point(531, 370);
            button_continue.Name = "button_continue";
            button_continue.Size = new Size(94, 29);
            button_continue.TabIndex = 7;
            button_continue.Text = "Continue";
            button_continue.UseVisualStyleBackColor = true;
            button_continue.Click += button_continue_Click;
            // 
            // button_exit
            // 
            button_exit.Location = new Point(354, 409);
            button_exit.Name = "button_exit";
            button_exit.Size = new Size(94, 29);
            button_exit.TabIndex = 8;
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
            Controls.Add(button_continue);
            Controls.Add(button_clear);
            Controls.Add(button_remove);
            Controls.Add(button_add);
            Controls.Add(listbox_input);
            Controls.Add(textbox_input);
            Controls.Add(label_input);
            Controls.Add(label_welcome);
            Name = "Form1";
            Text = "Home Page";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_welcome;
        private Label label_input;
        private TextBox textbox_input;
        private ListBox listbox_input;
        private Button button_add;
        private Button button_remove;
        private Button button_clear;
        private Button button_continue;
        private Button button_exit;
    }
}
