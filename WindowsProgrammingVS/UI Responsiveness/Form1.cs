using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIResponsiveness_PrgmInWindows
{
    public partial class Form1 : Form
    {
        public Label l = new Label();
        public int h, w, c1, c2;

        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.StartPosition = FormStartPosition.CenterScreen;
            timer_ui.Start();
            ToolTip t = new ToolTip();
            t.SetToolTip(label_progress, "See here the progress of form");
            t.SetToolTip(panel_ui, "See the change occuring after checking the check box");
            h = panel_ui.Size.Height;
            w = panel_ui.Size.Width;
            c1 = panel_ui.Location.X;
            c2 = panel_ui.Location.Y;
            checkbox_panelui.Anchor = AnchorStyles.Top & AnchorStyles.Bottom & AnchorStyles.Left & AnchorStyles.Right;
        }

        private void progressbar_ui_Click(object sender, EventArgs e)
        {

        }

        private void checkbox_panelui_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox_panelui.CheckState == CheckState.Checked)
            {
                panel_ui.Dock = DockStyle.Bottom;
                panel_ui.BackColor = Color.Beige;
            }
            else if (checkbox_panelui.CheckState == CheckState.Unchecked)
            {
                panel_ui.Dock = DockStyle.None;
                panel_ui.BackColor = Color.DarkGray;
                panel_ui.Anchor = AnchorStyles.Top & AnchorStyles.Bottom & AnchorStyles.Left & AnchorStyles.Right;
                checkbox_panelui.Anchor = AnchorStyles.Top & AnchorStyles.Left & AnchorStyles.Right & AnchorStyles.Bottom;
            }
            // Doubt received: On unchecking the checkbox, the panel
            // is not anchored at its original position and instead 
            // assumes random positions across the form. Also, the size
            // and coordinate values are not consistent with the original
            // panel properties set before execution of application
        }

        private void button_labelremove_Click(object sender, EventArgs e)
        {
            if (panel_ui.Controls.Contains(l))
            {
                panel_ui.Controls.Remove(l);
                MessageBox.Show("Label removed from panel!");
            }
            else
            {
                MessageBox.Show("Panel does not contain any label!", "Alert", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void button_continue_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            this.Hide();
            f.Show();
        }

        private void button_labeladd_Click(object sender, EventArgs e)
        {
            panel_ui.Controls.Add(l);
            l.Text = "Label added!";
        }

        private void timer_ui_Tick(object sender, EventArgs e)
        {
            progressbar_ui.Increment(4);
            label_progress.Text = progressbar_ui.Value.ToString();
            if (progressbar_ui.Value == 100)
            {
                timer_ui.Stop();
                MessageBox.Show("Form progress complete!");
                label_progress.Text = "Progress bar";
            }
        }

        private void panel_ui_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
