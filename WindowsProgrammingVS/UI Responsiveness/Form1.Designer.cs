namespace UIResponsiveness_PrgmInWindows
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
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            optionsToolStripMenuItem = new ToolStripMenuItem();
            restartToolStripMenuItem = new ToolStripMenuItem();
            panel_ui = new Panel();
            checkbox_panelui = new CheckBox();
            label_progress = new Label();
            progressbar_ui = new ProgressBar();
            timer_ui = new System.Windows.Forms.Timer(components);
            button_labeladd = new Button();
            button_continue = new Button();
            button_labelremove = new Button();
            menuStrip1.SuspendLayout();
            panel_ui.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, optionsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menustrip_main";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, saveAsToolStripMenuItem, saveToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.F;
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            newToolStripMenuItem.Size = new Size(175, 26);
            newToolStripMenuItem.Text = "New";
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new Size(175, 26);
            saveAsToolStripMenuItem.Text = "Save as";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveToolStripMenuItem.Size = new Size(175, 26);
            saveToolStripMenuItem.Text = "Save";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(175, 26);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // optionsToolStripMenuItem
            // 
            optionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { restartToolStripMenuItem });
            optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            optionsToolStripMenuItem.Size = new Size(75, 24);
            optionsToolStripMenuItem.Text = "Options";
            // 
            // restartToolStripMenuItem
            // 
            restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            restartToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.R;
            restartToolStripMenuItem.Size = new Size(189, 26);
            restartToolStripMenuItem.Text = "Restart";
            restartToolStripMenuItem.Click += restartToolStripMenuItem_Click;
            // 
            // panel_ui
            // 
            panel_ui.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel_ui.BackColor = SystemColors.ControlDark;
            panel_ui.Controls.Add(checkbox_panelui);
            panel_ui.Location = new Point(171, 123);
            panel_ui.Name = "panel_ui";
            panel_ui.Size = new Size(449, 213);
            panel_ui.TabIndex = 1;
            panel_ui.Paint += panel_ui_Paint;
            // 
            // checkbox_panelui
            // 
            checkbox_panelui.AutoSize = true;
            checkbox_panelui.Location = new Point(43, 48);
            checkbox_panelui.Name = "checkbox_panelui";
            checkbox_panelui.Size = new Size(242, 24);
            checkbox_panelui.TabIndex = 0;
            checkbox_panelui.Text = "Click here to change panel dock";
            checkbox_panelui.UseVisualStyleBackColor = true;
            checkbox_panelui.CheckedChanged += checkbox_panelui_CheckedChanged;
            // 
            // label_progress
            // 
            label_progress.AutoSize = true;
            label_progress.Dock = DockStyle.Left;
            label_progress.Location = new Point(0, 28);
            label_progress.Name = "label_progress";
            label_progress.Size = new Size(91, 20);
            label_progress.TabIndex = 2;
            label_progress.Text = "Progress bar";
            // 
            // progressbar_ui
            // 
            progressbar_ui.Dock = DockStyle.Top;
            progressbar_ui.Location = new Point(91, 28);
            progressbar_ui.Name = "progressbar_ui";
            progressbar_ui.Size = new Size(709, 29);
            progressbar_ui.TabIndex = 3;
            progressbar_ui.Click += progressbar_ui_Click;
            // 
            // timer_ui
            // 
            timer_ui.Tick += timer_ui_Tick;
            // 
            // button_labeladd
            // 
            button_labeladd.Anchor = AnchorStyles.Bottom;
            button_labeladd.Location = new Point(171, 382);
            button_labeladd.Name = "button_labeladd";
            button_labeladd.Size = new Size(94, 29);
            button_labeladd.TabIndex = 4;
            button_labeladd.Text = "Add label";
            button_labeladd.UseVisualStyleBackColor = true;
            button_labeladd.Click += button_labeladd_Click;
            // 
            // button_continue
            // 
            button_continue.Anchor = AnchorStyles.Bottom;
            button_continue.Location = new Point(526, 382);
            button_continue.Name = "button_continue";
            button_continue.Size = new Size(94, 29);
            button_continue.TabIndex = 5;
            button_continue.Text = "Continue";
            button_continue.UseVisualStyleBackColor = true;
            button_continue.Click += button_continue_Click;
            // 
            // button_labelremove
            // 
            button_labelremove.Anchor = AnchorStyles.Bottom;
            button_labelremove.Location = new Point(346, 382);
            button_labelremove.Name = "button_labelremove";
            button_labelremove.Size = new Size(94, 29);
            button_labelremove.TabIndex = 6;
            button_labelremove.Text = "Remove label";
            button_labelremove.UseVisualStyleBackColor = true;
            button_labelremove.Click += button_labelremove_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_labelremove);
            Controls.Add(button_continue);
            Controls.Add(button_labeladd);
            Controls.Add(progressbar_ui);
            Controls.Add(label_progress);
            Controls.Add(panel_ui);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Home Page";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel_ui.ResumeLayout(false);
            panel_ui.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ToolStripMenuItem restartToolStripMenuItem;
        private Panel panel_ui;
        private CheckBox checkbox_panelui;
        private Label label_progress;
        private ProgressBar progressbar_ui;
        private System.Windows.Forms.Timer timer_ui;
        private Button button_labeladd;
        private Button button_continue;
        private Button button_labelremove;
    }
}