namespace Graphics_addition_on_forms_Windows_Programming
{
    public partial class Form1 : Form
    {
        Graphics g;

        public Form1()
        {
            InitializeComponent();
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.DoubleBuffered = true;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // Graphics g = e.Graphics;

            // define a Pen for drawing figure
            // Pen p = new Pen(Color.Red, 5);  // Red pen with a width of 2 pixels

            // draw a rectangle at (50,50) coordinate with length=200 and height=150
            // g.DrawRectangle(p,50,50,200,150);

            // draw an ellipse
            // Rectangle ellipseRect = new Rectangle(50, 50, 200, 150);
            // g.DrawEllipse(p, ellipseRect);
            // g.DrawEllipse(p, 0, 0, 15, 20);   // alternate method of drawing an ellipse

            // Rectangle imgrect = new Rectangle(200, 200, 200, 150);
            // upload image
            // Image img = new Bitmap("C:/Users/Pranav Jain/Desktop/Gate paper 2024/Resumes/resume_pic.jpg");
            // using x and y coordinates
            // g.DrawImage(img, 200, 200);

            // using rectange object
            // g.DrawImage(img, imgrect); // frame in turn resizes image as per its size 

            // dispose figures made till date
            // g.Dispose(); // cleans the object and associated figures also 

            // origin (0,0) lies on Top-left corner
            // get the centre points of screen
            int h = this.ClientSize.Height;
            int w = this.ClientSize.Width;
            // g.DrawRectangle(p, w / 2 - 50, h / 2 - 50, 50, 40);

            // use Font configuration
            /*
            Graphics g1 = e.Graphics;
            Font font = new Font("Arial",14,FontStyle.Strikeout);
            Brush brush = Brushes.Magenta;
            string text = "Hello World!";
            g1.DrawString(text, font, brush, w / 2, h / 2);
            // w->x, h->y, don't think in terms of C/C++
            // Think that here, form opens as a rectangular frame
            // with a twist compared to <graphics.h>
            */

            // apply transformations to the graphics elements
            g = e.Graphics;
            g.TranslateTransform(50, 50);
            g.FillRectangle(Brushes.Red, 0, 0, 100, 100);

            // Rotation
            g.ResetTransform();
            g.TranslateTransform(200, 150);
            g.RotateTransform(45); // +ve for anticlockwise, -ve for vice versa
            g.FillRectangle(Brushes.Green, -50, -50, 100, 100);

            // Scaling
            g.ResetTransform();
            g.TranslateTransform(400, 100);
            g.ScaleTransform(1.5F, 0.5F);
            g.FillRectangle(Brushes.Blue, 0, 0, 100, 100);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(button1, "Click here to continue ahead");
            t.SetToolTip(button2, "Click here to exit the application");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            this.Hide();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            // DOUBT: Tried forcing the form to redraw elements
            // when the form is resized but not working
            this.Invalidate();
            // this.Refresh();
            this.Update();
            // Application.Run(this);
        }
    }
}
