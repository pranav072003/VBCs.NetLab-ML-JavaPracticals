namespace Assignment_4_Windows_Programming_theory
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
            listbox_choice = new ListBox();
            label1 = new Label();
            button_continue = new Button();
            button_back = new Button();
            button_reset = new Button();
            SuspendLayout();
            // 
            // listbox_choice
            // 
            listbox_choice.FormattingEnabled = true;
            listbox_choice.Items.AddRange(new object[] { "CSE", "IT", "ECE" });
            listbox_choice.Location = new Point(90, 68);
            listbox_choice.Name = "listbox_choice";
            listbox_choice.Size = new Size(611, 144);
            listbox_choice.TabIndex = 0;
            listbox_choice.SelectedIndexChanged += listbox_choice_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(32, 243);
            label1.Name = "label1";
            label1.Size = new Size(732, 27);
            label1.TabIndex = 1;
            label1.Text = "Observe the changes made to the listbox upon selecting an item!";
            // 
            // button_continue
            // 
            button_continue.Location = new Point(216, 326);
            button_continue.Name = "button_continue";
            button_continue.Size = new Size(94, 29);
            button_continue.TabIndex = 2;
            button_continue.Text = "Continue";
            button_continue.UseVisualStyleBackColor = true;
            button_continue.Click += button_continue_Click;
            // 
            // button_back
            // 
            button_back.Location = new Point(451, 326);
            button_back.Name = "button_back";
            button_back.Size = new Size(94, 29);
            button_back.TabIndex = 3;
            button_back.Text = "Back";
            button_back.UseVisualStyleBackColor = true;
            button_back.Click += button_back_Click;
            // 
            // button_reset
            // 
            button_reset.Location = new Point(334, 326);
            button_reset.Name = "button_reset";
            button_reset.Size = new Size(94, 29);
            button_reset.TabIndex = 4;
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
            Controls.Add(button_back);
            Controls.Add(button_continue);
            Controls.Add(label1);
            Controls.Add(listbox_choice);
            Name = "Form2";
            Text = "Navigation Page";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listbox_choice;
        private Label label1;
        private Button button_continue;
        private Button button_back;
        private Button button_reset;
    }
}