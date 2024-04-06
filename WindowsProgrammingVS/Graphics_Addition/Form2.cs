using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphics_addition_on_forms_Windows_Programming
{
    public partial class Form2 : Form
    {
        Graphics DrawingSpace;

        public Form2()
        {
            InitializeComponent();
            // set Graphics object upon a control for adding graphics to it
            // DrawingSpace = pictureBox1.CreateGraphics();
            DrawingSpace = panel1.CreateGraphics();
        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(button1, "Click here to draw a line");
            t.SetToolTip(button2, "Click here to draw a rectangle");
            t.SetToolTip(button3, "Click here to exit the application");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // take in input from user
            var arr = textBox1.Text.Split();
            string color = textBox2.Text;  // get color inputted by user
            if(arr.Length != 4)
            {
                MessageBox.Show("Error", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            float[] coord = new float[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                // parse arr values as double
                /* can also use Convert.ToSingle(); 
                for conversion into single point precision */
                double v = Convert.ToDouble(arr[i]);
                coord[i] = (float)v;
            }
            // Use Reset, Refresh or Clear to clear the drawing space
            // on which graphics are created/added
            DrawingSpace.Clear(DefaultBackColor);
            Pen p;  // create an empty reference to Pen object
            if(color=="Black")
            {
                p = new Pen(Color.Black, 2);
            }
            else
            {
                // using default option to create pen object
                p = new Pen(Color.Red, 2);
            }
            DrawingSpace.DrawLine(p, coord[0], coord[1], coord[2], coord[3]);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string color = textBox2.Text;  // get color inputted by user
            // take in input from user
            Pen p; // create an empty reference to Pen object
            if (color == "Black")
            {
                p = new Pen(Color.Black, 3);
            }
            else
            {
                // using default option to create pen object
                p = new Pen(Color.Blue, 3);
            }
            var arr = textBox1.Text.Split();
            var arr_len = textBox3.Text.Split();
            // assuming arr_len[0] as width, arr_len[1] as height
            if ((arr.Length != 0 && !checkBox1.Checked) && arr.Length != 2)
            {
                MessageBox.Show("Invalid number of Arguments", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            if (checkBox1.Checked)
            {
                this.Refresh(); // using Refresh method
                // searched but found no Reset method
                // DrawingSpace.Clear(DefaultBackColor);
                int h = panel1.Height;
                int w = panel1.Width;
                DrawingSpace.DrawRectangle(p, w / 2, h / 2, Convert.ToSingle(arr_len[0]), Convert.ToSingle(arr_len[1]));
                return;
            }
            float[] coord = new float[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                // parse arr values as double
                coord[i] = Convert.ToSingle(arr[i]);
                // using ToSingle instead of ToDouble
            }
            // Use Reset, Refresh or Clear to clear the drawing space
            // on which graphics are created/added
            DrawingSpace.Clear(DefaultBackColor);
            DrawingSpace.DrawRectangle(p, coord[0], coord[1], Convert.ToSingle(arr_len[0]), Convert.ToSingle(arr_len[1]));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
