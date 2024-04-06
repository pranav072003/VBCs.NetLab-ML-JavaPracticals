namespace Graphics_addition_on_forms_Windows_Programming
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
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            button3 = new Button();
            label2 = new Label();
            textBox2 = new TextBox();
            checkBox1 = new CheckBox();
            label3 = new Label();
            textBox3 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(677, 351);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(10, 17);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Location = new Point(49, 229);
            panel1.Name = "panel1";
            panel1.Size = new Size(501, 188);
            panel1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(577, 339);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Draw Line";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(579, 388);
            button2.Name = "button2";
            button2.Size = new Size(158, 29);
            button2.TabIndex = 3;
            button2.Text = "Draw Rectangle";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Historic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(136, 47);
            label1.Name = "label1";
            label1.Size = new Size(303, 20);
            label1.TabIndex = 4;
            label1.Text = "Enter the coordinates for the line/rectangle:-";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(454, 44);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(204, 27);
            textBox1.TabIndex = 5;
            // 
            // button3
            // 
            button3.Location = new Point(577, 292);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 6;
            button3.Text = "Exit";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(93, 100);
            label2.Name = "label2";
            label2.Size = new Size(356, 20);
            label2.TabIndex = 7;
            label2.Text = "Enter colour which is to be used for creating figure:- ";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(454, 100);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(204, 27);
            textBox2.TabIndex = 8;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(183, 155);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(475, 24);
            checkBox1.TabIndex = 9;
            checkBox1.Text = "Want to use the screen middle section for displaying the rectangle?";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(80, 194);
            label3.Name = "label3";
            label3.Size = new Size(383, 20);
            label3.TabIndex = 10;
            label3.Text = "Enter the height and width of the rectangle to be made:-";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(469, 193);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(180, 27);
            textBox3.TabIndex = 11;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(checkBox1);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "Form2";
            Text = "Paint App Implementation";
            Load += Form2_Load;
            Paint += Form2_Paint;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Button button1;
        private Button button2;
        private Label label1;
        private TextBox textBox1;
        private Button button3;
        private Label label2;
        private TextBox textBox2;
        private CheckBox checkBox1;
        private Label label3;
        private TextBox textBox3;
    }
}