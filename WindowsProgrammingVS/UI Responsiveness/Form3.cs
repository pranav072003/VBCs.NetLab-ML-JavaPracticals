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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button_calarper_Click(object sender, EventArgs e)
        {
            double r;
            // DONE: parse string input as double
            r = Double.Parse(textbox_radius.Text);
            double area = Math.PI * Math.Pow(r, 2);
            double circumference = 2 * Math.PI * r;
            MessageBox.Show("Area is " + area.ToString() + " and circumference is " + circumference.ToString());
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            this.Hide();
            f.Show();
        }
    }
}
