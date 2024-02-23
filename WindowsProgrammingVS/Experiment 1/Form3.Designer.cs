namespace Programming_in_Windows_Practical_1
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
            textbox_num1 = new TextBox();
            textbox_num2 = new TextBox();
            label2 = new Label();
            button_add = new Button();
            button_sub = new Button();
            button_divide = new Button();
            button_sqrt = new Button();
            button_back = new Button();
            button_multiply = new Button();
            button_square = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(178, 99);
            label1.Name = "label1";
            label1.Size = new Size(101, 25);
            label1.TabIndex = 0;
            label1.Text = "Number 1:- ";
            // 
            // textbox_num1
            // 
            textbox_num1.Location = new Point(354, 97);
            textbox_num1.Name = "textbox_num1";
            textbox_num1.Size = new Size(285, 27);
            textbox_num1.TabIndex = 1;
            // 
            // textbox_num2
            // 
            textbox_num2.Location = new Point(354, 159);
            textbox_num2.Name = "textbox_num2";
            textbox_num2.Size = new Size(285, 27);
            textbox_num2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(178, 161);
            label2.Name = "label2";
            label2.Size = new Size(103, 25);
            label2.TabIndex = 2;
            label2.Text = "Number 2:- ";
            // 
            // button_add
            // 
            button_add.Location = new Point(205, 227);
            button_add.Name = "button_add";
            button_add.Size = new Size(94, 29);
            button_add.TabIndex = 4;
            button_add.Text = "Add";
            button_add.UseVisualStyleBackColor = true;
            button_add.Click += button_add_Click;
            // 
            // button_sub
            // 
            button_sub.Location = new Point(354, 227);
            button_sub.Name = "button_sub";
            button_sub.Size = new Size(94, 29);
            button_sub.TabIndex = 5;
            button_sub.Text = "Subtract";
            button_sub.UseVisualStyleBackColor = true;
            button_sub.Click += button_sub_Click;
            // 
            // button_divide
            // 
            button_divide.Location = new Point(500, 227);
            button_divide.Name = "button_divide";
            button_divide.Size = new Size(94, 29);
            button_divide.TabIndex = 6;
            button_divide.Text = "Divide";
            button_divide.UseVisualStyleBackColor = true;
            button_divide.Click += button_divide_Click;
            // 
            // button_sqrt
            // 
            button_sqrt.Location = new Point(253, 284);
            button_sqrt.Name = "button_sqrt";
            button_sqrt.Size = new Size(144, 29);
            button_sqrt.TabIndex = 7;
            button_sqrt.Text = "Square Root";
            button_sqrt.UseVisualStyleBackColor = true;
            button_sqrt.Click += button_sqrt_Click;
            // 
            // button_back
            // 
            button_back.Location = new Point(432, 337);
            button_back.Name = "button_back";
            button_back.Size = new Size(94, 29);
            button_back.TabIndex = 8;
            button_back.Text = "Back";
            button_back.UseVisualStyleBackColor = true;
            button_back.Click += button_back_Click;
            // 
            // button_multiply
            // 
            button_multiply.Location = new Point(469, 284);
            button_multiply.Name = "button_multiply";
            button_multiply.Size = new Size(94, 29);
            button_multiply.TabIndex = 9;
            button_multiply.Text = "Multiply";
            button_multiply.UseVisualStyleBackColor = true;
            button_multiply.Click += button_multiply_Click;
            // 
            // button_square
            // 
            button_square.Location = new Point(303, 337);
            button_square.Name = "button_square";
            button_square.Size = new Size(94, 29);
            button_square.TabIndex = 10;
            button_square.Text = "Square";
            button_square.UseVisualStyleBackColor = true;
            button_square.Click += button_square_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_square);
            Controls.Add(button_multiply);
            Controls.Add(button_back);
            Controls.Add(button_sqrt);
            Controls.Add(button_divide);
            Controls.Add(button_sub);
            Controls.Add(button_add);
            Controls.Add(textbox_num2);
            Controls.Add(label2);
            Controls.Add(textbox_num1);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Operator Page";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textbox_num1;
        private TextBox textbox_num2;
        private Label label2;
        private Button button_add;
        private Button button_sub;
        private Button button_divide;
        private Button button_sqrt;
        private Button button_back;
        private Button button_multiply;
        private Button button_square;
    }
}