namespace UIResponsiveness_PrgmInWindows
{
    partial class Form3
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
            textbox_radius = new TextBox();
            button_back = new Button();
            button_calarper = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(214, 99);
            label1.Name = "label1";
            label1.Size = new Size(142, 28);
            label1.TabIndex = 0;
            label1.Text = "Enter Radius:-";
            // 
            // textbox_radius
            // 
            textbox_radius.Location = new Point(395, 99);
            textbox_radius.Name = "textbox_radius";
            textbox_radius.Size = new Size(125, 27);
            textbox_radius.TabIndex = 1;
            // 
            // button_back
            // 
            button_back.Location = new Point(521, 192);
            button_back.Name = "button_back";
            button_back.Size = new Size(94, 29);
            button_back.TabIndex = 2;
            button_back.Text = "Back";
            button_back.UseVisualStyleBackColor = true;
            button_back.Click += button_back_Click;
            // 
            // button_calarper
            // 
            button_calarper.Location = new Point(160, 192);
            button_calarper.Name = "button_calarper";
            button_calarper.Size = new Size(258, 29);
            button_calarper.TabIndex = 3;
            button_calarper.Text = "Calculate Area and perimeter";
            button_calarper.UseVisualStyleBackColor = true;
            button_calarper.Click += button_calarper_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_calarper);
            Controls.Add(button_back);
            Controls.Add(textbox_radius);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textbox_radius;
        private Button button_back;
        private Button button_calarper;
    }
}