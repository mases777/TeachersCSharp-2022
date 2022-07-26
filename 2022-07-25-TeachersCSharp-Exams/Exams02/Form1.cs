namespace Exams02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int a = 256, freq = 500, rep = 20;
            Random c = new Random();
            for (int i = 1; i <= rep; i++)
            {
                g.Clear(Color.FromArgb(c.Next() % a, c.Next() % a, c.Next() % a));
                System.Threading.Thread.Sleep(freq);
            }
            Pen p = new Pen(Color.Black, 3);
            Pen p1 = new Pen(Color.Blue, 3);
            Point b = new Point(123, 24);
            Point d = new Point(12, 242);
            g.DrawLine(p, 0, 0, 100, 100);
            g.DrawLine(p, b, d);
            g.DrawRectangle(p, 50, 50, 200, 100);
            g.DrawEllipse(p, 50, 50, 200, 100);
            g.DrawArc(p1, 50, 50, 200, 100, 0, 90);
            g.DrawArc(p1, 50, 50, 200, 100, 300, 100);
        }
    }
}