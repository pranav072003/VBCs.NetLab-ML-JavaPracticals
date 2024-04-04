namespace Programming_in_Windows_Practical_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // g1: Sun, g2: Rectangle, g3: Man, g4: Ellipse
            Graphics g1 = e.Graphics;
            Graphics g2 = e.Graphics;
            Graphics g3 = e.Graphics;
            Graphics g4 = e.Graphics;
            Pen p1 = new Pen(Color.OrangeRed, 5);
            // creating sun using red-yellow color
            Pen p2 = new Pen(Color.Cyan, 3);
            // creating rectangle with red color (background color to be cyan)
            Pen p3 = new Pen(Color.PeachPuff, 3);
            // creating man with peach-skin color

            // get the mid value coordinates on screen
            int h = this.ClientSize.Height;
            int w = this.ClientSize.Width;

            // drawing a circle object Sun
            g1.DrawEllipse(p1, 25, 25, 95, 95);
            // creating a brush to fill the circle with yellow color
            Brush Sun_b = new SolidBrush(Color.Yellow);
            g1.FillEllipse(Sun_b, 25, 25, 95, 95);

            // drawing a rectangle object
            g2.DrawRectangle(p2, 250, 25, 150, 100);
            Brush Rect_b = new SolidBrush(Color.Cyan);
            g2.FillRectangle(Rect_b, 250, 25, 150, 100);

            // drawing an ellipse
            Rectangle rect_ellipse = new Rectangle(w/2 - 45, h/2 - 45, 60, 40);
            g4.DrawEllipse(p3 , rect_ellipse);
            g4.FillEllipse(Rect_b, rect_ellipse.X, rect_ellipse.Y, rect_ellipse.Width, rect_ellipse.Height);

            // drawing a Man Object
            g3.DrawEllipse(p3, w / 2 + 50, h / 2, 45, 45);
            PointF head = new PointF(w / 2 + 72, h / 2 + 45);
            PointF end = new PointF(w / 2 + 72, h / 2 + 125);
            g3.DrawLine(p3, head, end);
            PointF poi1 = new PointF(w / 2 + 72, h / 2 + 125);
            PointF poi2 = new PointF(w / 2 + 55, h / 2 + 145);
            PointF poi3 = new PointF(w / 2 + 87, h / 2 + 145);
            g3.DrawLine(p3, poi1, poi3);
            g3.DrawLine(p3, poi1, poi2);
            PointF hand1 = new PointF(w / 2 + 72, h / 2 + 65);
            PointF hand2 = new PointF(w / 2 + 55, h / 2 + 95);
            PointF hand3 = new PointF(w / 2 + 87, h / 2 + 95);
            g3.DrawLine(p3,hand1, hand2);
            g3.DrawLine(p3, hand1, hand3);

            // add an image 
            Image img = new Bitmap("C:/Users/Pranav Jain/Desktop/Gate paper 2024/Resumes/resume_pic.jpg");
            Rectangle rect_img = new Rectangle(150, 150, 100, 100);
            g3.DrawImage(img, rect_img);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
