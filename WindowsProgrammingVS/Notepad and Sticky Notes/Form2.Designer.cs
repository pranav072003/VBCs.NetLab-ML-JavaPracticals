namespace Assignment_5_Windows_Programming_theory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            menu_stickynotes = new MenuStrip();
            file_button = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            backToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            edit_button = new ToolStripMenuItem();
            undoToolStripMenuItem = new ToolStripMenuItem();
            cutToolStripMenuItem = new ToolStripMenuItem();
            copyToolStripMenuItem = new ToolStripMenuItem();
            pasteToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            dateTimeToolStripMenuItem = new ToolStripMenuItem();
            stickynotes_textbox = new RichTextBox();
            button_new = new Button();
            button_settings = new Button();
            button_close = new Button();
            button_bold = new Button();
            button_italics = new Button();
            button_underline = new Button();
            button_linethrough = new Button();
            button_list = new Button();
            button_img = new Button();
            saveFileDialog_stickynote = new SaveFileDialog();
            openFileDialog_stickynote = new OpenFileDialog();
            openFileDialog_img = new OpenFileDialog();
            menu_stickynotes.SuspendLayout();
            SuspendLayout();
            // 
            // menu_stickynotes
            // 
            menu_stickynotes.ImageScalingSize = new Size(20, 20);
            menu_stickynotes.Items.AddRange(new ToolStripItem[] { file_button, edit_button });
            menu_stickynotes.Location = new Point(0, 0);
            menu_stickynotes.Name = "menu_stickynotes";
            menu_stickynotes.Size = new Size(800, 28);
            menu_stickynotes.TabIndex = 0;
            menu_stickynotes.Text = "menuStrip1";
            // 
            // file_button
            // 
            file_button.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, saveAsToolStripMenuItem, backToolStripMenuItem, exitToolStripMenuItem });
            file_button.Name = "file_button";
            file_button.Size = new Size(46, 24);
            file_button.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            openToolStripMenuItem.Size = new Size(193, 26);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveAsToolStripMenuItem.Size = new Size(193, 26);
            saveAsToolStripMenuItem.Text = "Save As";
            saveAsToolStripMenuItem.Click += saveAsToolStripMenuItem_Click;
            // 
            // backToolStripMenuItem
            // 
            backToolStripMenuItem.Name = "backToolStripMenuItem";
            backToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.B;
            backToolStripMenuItem.Size = new Size(193, 26);
            backToolStripMenuItem.Text = "Back ";
            backToolStripMenuItem.Click += backToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(193, 26);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // edit_button
            // 
            edit_button.DropDownItems.AddRange(new ToolStripItem[] { undoToolStripMenuItem, cutToolStripMenuItem, copyToolStripMenuItem, pasteToolStripMenuItem, deleteToolStripMenuItem, dateTimeToolStripMenuItem });
            edit_button.Name = "edit_button";
            edit_button.Size = new Size(49, 24);
            edit_button.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            undoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Z;
            undoToolStripMenuItem.Size = new Size(187, 26);
            undoToolStripMenuItem.Text = "Undo";
            undoToolStripMenuItem.Click += undoToolStripMenuItem_Click;
            // 
            // cutToolStripMenuItem
            // 
            cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            cutToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            cutToolStripMenuItem.Size = new Size(187, 26);
            cutToolStripMenuItem.Text = "Cut";
            cutToolStripMenuItem.Click += cutToolStripMenuItem_Click;
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            copyToolStripMenuItem.Size = new Size(187, 26);
            copyToolStripMenuItem.Text = "Copy";
            copyToolStripMenuItem.Click += copyToolStripMenuItem_Click;
            // 
            // pasteToolStripMenuItem
            // 
            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            pasteToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.V;
            pasteToolStripMenuItem.Size = new Size(187, 26);
            pasteToolStripMenuItem.Text = "Paste";
            pasteToolStripMenuItem.Click += pasteToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.ShortcutKeys = Keys.Delete;
            deleteToolStripMenuItem.Size = new Size(187, 26);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // dateTimeToolStripMenuItem
            // 
            dateTimeToolStripMenuItem.Name = "dateTimeToolStripMenuItem";
            dateTimeToolStripMenuItem.ShortcutKeys = Keys.F5;
            dateTimeToolStripMenuItem.Size = new Size(187, 26);
            dateTimeToolStripMenuItem.Text = "Date/Time";
            dateTimeToolStripMenuItem.Click += dateTimeToolStripMenuItem_Click;
            // 
            // stickynotes_textbox
            // 
            stickynotes_textbox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            stickynotes_textbox.BackColor = Color.DarkOrange;
            stickynotes_textbox.Location = new Point(147, 103);
            stickynotes_textbox.Name = "stickynotes_textbox";
            stickynotes_textbox.Size = new Size(504, 223);
            stickynotes_textbox.TabIndex = 1;
            stickynotes_textbox.Text = "";
            // 
            // button_new
            // 
            button_new.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_new.Location = new Point(147, 37);
            button_new.Name = "button_new";
            button_new.Size = new Size(56, 60);
            button_new.TabIndex = 2;
            button_new.Text = "+";
            button_new.UseVisualStyleBackColor = true;
            button_new.Click += button_new_Click;
            // 
            // button_settings
            // 
            button_settings.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_settings.Location = new Point(530, 37);
            button_settings.Name = "button_settings";
            button_settings.Size = new Size(65, 60);
            button_settings.TabIndex = 3;
            button_settings.Text = "...";
            button_settings.UseVisualStyleBackColor = true;
            button_settings.Click += button_settings_Click;
            // 
            // button_close
            // 
            button_close.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_close.Location = new Point(607, 37);
            button_close.Name = "button_close";
            button_close.Size = new Size(65, 60);
            button_close.TabIndex = 4;
            button_close.Text = "X";
            button_close.UseVisualStyleBackColor = true;
            button_close.Click += button_close_Click;
            // 
            // button_bold
            // 
            button_bold.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_bold.Location = new Point(147, 338);
            button_bold.Name = "button_bold";
            button_bold.Size = new Size(56, 60);
            button_bold.TabIndex = 5;
            button_bold.Text = "B";
            button_bold.UseVisualStyleBackColor = true;
            button_bold.Click += button_bold_Click;
            // 
            // button_italics
            // 
            button_italics.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_italics.Location = new Point(209, 338);
            button_italics.Name = "button_italics";
            button_italics.Size = new Size(56, 60);
            button_italics.TabIndex = 6;
            button_italics.Text = "I";
            button_italics.UseVisualStyleBackColor = true;
            button_italics.Click += button_italics_Click;
            // 
            // button_underline
            // 
            button_underline.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_underline.Location = new Point(271, 338);
            button_underline.Name = "button_underline";
            button_underline.Size = new Size(56, 60);
            button_underline.TabIndex = 7;
            button_underline.Text = "U";
            button_underline.UseVisualStyleBackColor = true;
            button_underline.Click += button_underline_Click;
            // 
            // button_linethrough
            // 
            button_linethrough.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_linethrough.Location = new Point(333, 338);
            button_linethrough.Name = "button_linethrough";
            button_linethrough.Size = new Size(100, 60);
            button_linethrough.TabIndex = 8;
            button_linethrough.Text = "-abc-";
            button_linethrough.UseVisualStyleBackColor = true;
            button_linethrough.Click += button_linethrough_Click;
            // 
            // button_list
            // 
            button_list.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_list.Location = new Point(439, 338);
            button_list.Name = "button_list";
            button_list.Size = new Size(96, 60);
            button_list.TabIndex = 9;
            button_list.Text = ". -----";
            button_list.UseVisualStyleBackColor = true;
            button_list.Click += button_list_Click;
            // 
            // button_img
            // 
            button_img.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_img.Location = new Point(541, 338);
            button_img.Name = "button_img";
            button_img.Size = new Size(131, 60);
            button_img.TabIndex = 10;
            button_img.Text = "Add Image";
            button_img.UseVisualStyleBackColor = true;
            button_img.Click += button_img_Click;
            // 
            // openFileDialog_stickynote
            // 
            openFileDialog_stickynote.FileName = "openFileDialog1";
            // 
            // openFileDialog_img
            // 
            openFileDialog_img.FileName = "openFileDialog1";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_img);
            Controls.Add(button_list);
            Controls.Add(button_linethrough);
            Controls.Add(button_underline);
            Controls.Add(button_italics);
            Controls.Add(button_bold);
            Controls.Add(button_close);
            Controls.Add(button_settings);
            Controls.Add(button_new);
            Controls.Add(stickynotes_textbox);
            Controls.Add(menu_stickynotes);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menu_stickynotes;
            Name = "Form2";
            Text = "Sticky Notes";
            Load += Form2_Load;
            menu_stickynotes.ResumeLayout(false);
            menu_stickynotes.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menu_stickynotes;
        private ToolStripMenuItem file_button;
        private ToolStripMenuItem backToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private RichTextBox stickynotes_textbox;
        private Button button_new;
        private Button button_settings;
        private Button button_close;
        private Button button_bold;
        private Button button_italics;
        private Button button_underline;
        private Button button_linethrough;
        private Button button_list;
        private Button button_img;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private SaveFileDialog saveFileDialog_stickynote;
        private OpenFileDialog openFileDialog_stickynote;
        private ToolStripMenuItem edit_button;
        private ToolStripMenuItem undoToolStripMenuItem;
        private ToolStripMenuItem cutToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem dateTimeToolStripMenuItem;
        private OpenFileDialog openFileDialog_img;
    }
}