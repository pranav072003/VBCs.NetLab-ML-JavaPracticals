namespace Assignment_3_Windows_Programming_theory
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
            label_gender = new Label();
            combobox_gender = new ComboBox();
            label_dept = new Label();
            panel_dept = new Panel();
            radiobutton_pr = new RadioButton();
            radiobutton_it = new RadioButton();
            radiobutton_marketing = new RadioButton();
            radiobutton_prod = new RadioButton();
            radiobutton_acc = new RadioButton();
            radiobutton_hrd = new RadioButton();
            label_resadd = new Label();
            textbox_address = new TextBox();
            textbox_number = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textbox_emailid = new TextBox();
            label_emailid = new Label();
            button_submit = new Button();
            button_back = new Button();
            button_reset = new Button();
            panel_dept.SuspendLayout();
            SuspendLayout();
            // 
            // label_gender
            // 
            label_gender.AutoSize = true;
            label_gender.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_gender.Location = new Point(200, 91);
            label_gender.Name = "label_gender";
            label_gender.Size = new Size(84, 27);
            label_gender.TabIndex = 0;
            label_gender.Text = "Gender:-";
            // 
            // combobox_gender
            // 
            combobox_gender.DisplayMember = "Male";
            combobox_gender.FormattingEnabled = true;
            combobox_gender.Items.AddRange(new object[] { "Male", "Female", "Others" });
            combobox_gender.Location = new Point(348, 90);
            combobox_gender.Name = "combobox_gender";
            combobox_gender.Size = new Size(151, 28);
            combobox_gender.TabIndex = 1;
            combobox_gender.ValueMember = "Male";
            // 
            // label_dept
            // 
            label_dept.AutoSize = true;
            label_dept.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_dept.Location = new Point(200, 151);
            label_dept.Name = "label_dept";
            label_dept.Size = new Size(119, 27);
            label_dept.TabIndex = 2;
            label_dept.Text = "Department:-";
            // 
            // panel_dept
            // 
            panel_dept.AutoScroll = true;
            panel_dept.Controls.Add(radiobutton_pr);
            panel_dept.Controls.Add(radiobutton_it);
            panel_dept.Controls.Add(radiobutton_marketing);
            panel_dept.Controls.Add(radiobutton_prod);
            panel_dept.Controls.Add(radiobutton_acc);
            panel_dept.Controls.Add(radiobutton_hrd);
            panel_dept.Location = new Point(348, 151);
            panel_dept.Name = "panel_dept";
            panel_dept.Size = new Size(283, 97);
            panel_dept.TabIndex = 3;
            // 
            // radiobutton_pr
            // 
            radiobutton_pr.AutoSize = true;
            radiobutton_pr.Location = new Point(34, 153);
            radiobutton_pr.Name = "radiobutton_pr";
            radiobutton_pr.Size = new Size(135, 24);
            radiobutton_pr.TabIndex = 4;
            radiobutton_pr.TabStop = true;
            radiobutton_pr.Text = "Public Relations";
            radiobutton_pr.UseVisualStyleBackColor = true;
            // 
            // radiobutton_it
            // 
            radiobutton_it.AutoSize = true;
            radiobutton_it.Location = new Point(34, 123);
            radiobutton_it.Name = "radiobutton_it";
            radiobutton_it.Size = new Size(71, 24);
            radiobutton_it.TabIndex = 4;
            radiobutton_it.TabStop = true;
            radiobutton_it.Text = "IT Cell";
            radiobutton_it.UseVisualStyleBackColor = true;
            // 
            // radiobutton_marketing
            // 
            radiobutton_marketing.AutoSize = true;
            radiobutton_marketing.Location = new Point(34, 93);
            radiobutton_marketing.Name = "radiobutton_marketing";
            radiobutton_marketing.Size = new Size(97, 24);
            radiobutton_marketing.TabIndex = 4;
            radiobutton_marketing.TabStop = true;
            radiobutton_marketing.Text = "Marketing";
            radiobutton_marketing.UseVisualStyleBackColor = true;
            // 
            // radiobutton_prod
            // 
            radiobutton_prod.AutoSize = true;
            radiobutton_prod.Location = new Point(34, 63);
            radiobutton_prod.Name = "radiobutton_prod";
            radiobutton_prod.Size = new Size(102, 24);
            radiobutton_prod.TabIndex = 2;
            radiobutton_prod.TabStop = true;
            radiobutton_prod.Text = "Production";
            radiobutton_prod.UseVisualStyleBackColor = true;
            radiobutton_prod.CheckedChanged += radiobutton_prod_CheckedChanged;
            // 
            // radiobutton_acc
            // 
            radiobutton_acc.AutoSize = true;
            radiobutton_acc.Location = new Point(34, 33);
            radiobutton_acc.Name = "radiobutton_acc";
            radiobutton_acc.Size = new Size(173, 24);
            radiobutton_acc.TabIndex = 1;
            radiobutton_acc.TabStop = true;
            radiobutton_acc.Text = "Accounts and Finance";
            radiobutton_acc.UseVisualStyleBackColor = true;
            // 
            // radiobutton_hrd
            // 
            radiobutton_hrd.AutoSize = true;
            radiobutton_hrd.Location = new Point(34, 3);
            radiobutton_hrd.Name = "radiobutton_hrd";
            radiobutton_hrd.Size = new Size(205, 24);
            radiobutton_hrd.TabIndex = 0;
            radiobutton_hrd.TabStop = true;
            radiobutton_hrd.Text = "Human Resources Training";
            radiobutton_hrd.UseVisualStyleBackColor = true;
            radiobutton_hrd.CheckedChanged += radiobutton_hrd_CheckedChanged;
            // 
            // label_resadd
            // 
            label_resadd.AutoSize = true;
            label_resadd.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_resadd.Location = new Point(159, 274);
            label_resadd.Name = "label_resadd";
            label_resadd.Size = new Size(185, 27);
            label_resadd.TabIndex = 4;
            label_resadd.Text = "Residential Address:-";
            // 
            // textbox_address
            // 
            textbox_address.Location = new Point(350, 274);
            textbox_address.Name = "textbox_address";
            textbox_address.Size = new Size(205, 27);
            textbox_address.TabIndex = 5;
            // 
            // textbox_number
            // 
            textbox_number.Location = new Point(350, 321);
            textbox_number.Name = "textbox_number";
            textbox_number.Size = new Size(205, 27);
            textbox_number.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(159, 321);
            label1.Name = "label1";
            label1.Size = new Size(162, 27);
            label1.TabIndex = 6;
            label1.Text = "Contact Number:- ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(287, 26);
            label2.Name = "label2";
            label2.Size = new Size(344, 27);
            label2.TabIndex = 8;
            label2.Text = "Please fill out the following details as well";
            // 
            // textbox_emailid
            // 
            textbox_emailid.Location = new Point(350, 368);
            textbox_emailid.Name = "textbox_emailid";
            textbox_emailid.Size = new Size(205, 27);
            textbox_emailid.TabIndex = 10;
            // 
            // label_emailid
            // 
            label_emailid.AutoSize = true;
            label_emailid.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_emailid.Location = new Point(159, 368);
            label_emailid.Name = "label_emailid";
            label_emailid.Size = new Size(93, 27);
            label_emailid.TabIndex = 9;
            label_emailid.Text = "Email ID:-";
            // 
            // button_submit
            // 
            button_submit.Location = new Point(250, 421);
            button_submit.Name = "button_submit";
            button_submit.Size = new Size(94, 29);
            button_submit.TabIndex = 11;
            button_submit.Text = "Submit";
            button_submit.UseVisualStyleBackColor = true;
            button_submit.Click += button_submit_Click;
            // 
            // button_back
            // 
            button_back.Location = new Point(385, 421);
            button_back.Name = "button_back";
            button_back.Size = new Size(94, 29);
            button_back.TabIndex = 12;
            button_back.Text = "Back";
            button_back.UseVisualStyleBackColor = true;
            button_back.Click += button_back_Click;
            // 
            // button_reset
            // 
            button_reset.Location = new Point(515, 421);
            button_reset.Name = "button_reset";
            button_reset.Size = new Size(94, 29);
            button_reset.TabIndex = 13;
            button_reset.Text = "Reset";
            button_reset.UseVisualStyleBackColor = true;
            button_reset.Click += button_reset_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(800, 450);
            Controls.Add(button_reset);
            Controls.Add(button_back);
            Controls.Add(button_submit);
            Controls.Add(textbox_emailid);
            Controls.Add(label_emailid);
            Controls.Add(label2);
            Controls.Add(textbox_number);
            Controls.Add(label1);
            Controls.Add(textbox_address);
            Controls.Add(label_resadd);
            Controls.Add(panel_dept);
            Controls.Add(label_dept);
            Controls.Add(combobox_gender);
            Controls.Add(label_gender);
            Name = "Form3";
            Text = "Final Page Registration ";
            panel_dept.ResumeLayout(false);
            panel_dept.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_gender;
        private ComboBox combobox_gender;
        private Label label_dept;
        private Panel panel_dept;
        private RadioButton radiobutton_hrd;
        private RadioButton radiobutton_acc;
        private RadioButton radiobutton_prod;
        private RadioButton radiobutton_marketing;
        private RadioButton radiobutton_it;
        private RadioButton radiobutton_pr;
        private Label label_resadd;
        private TextBox textbox_address;
        private TextBox textbox_number;
        private Label label1;
        private Label label2;
        private TextBox textbox_emailid;
        private Label label_emailid;
        private Button button_submit;
        private Button button_back;
        private Button button_reset;
    }
}