using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr16_3._3_Лихачев
{
    public partial class Form1 : Form
    {
        Graphics g;
        public Form1()
        {
            InitializeComponent();
            g = Graphics.FromHwnd(this.Handle);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
        }

        private Point[] star5(int x, int y, int r)
        {
            Point point1 = new Point(x, y - 6 * r);
            Point point2 = new Point(x + 2 * r, y - 3 * r);
            Point point3 = new Point(x + 6 * r, y - 2 * r);
            Point point4 = new Point(x + 3 * r, y + r);
            Point point5 = new Point(x + 4 * r, y + 5 * r);
            Point point6 = new Point(x, y + 3 * r);
            Point point7 = new Point(x - 4 * r, y + 5 * r);
            Point point8 = new Point(x - 3 * r, y + r);
            Point point9 = new Point(x - 6 * r, y - 2 * r);
            Point point10 = new Point(x - 2 * r, y - 3 * r);
            Point[] pm =
            {
                point1,
                point2,
                point3,
                point4,
                point5,
                point6,
                point7,
                point8,
                point9,
                point10
            };
            return pm;
        }

        public Color RandomColor()
        {
            int r, g, b;
            byte[] bytes1 = new byte[3];
            Random rnd1 = new Random();
            rnd1.NextBytes(bytes1);
            r = Convert.ToInt16(bytes1[0]);
            g = Convert.ToInt16(bytes1[1]);
            b = Convert.ToInt16(bytes1[2]);

            return Color.FromArgb(r, g, b);
        }

        private void замкнутаяЛоманаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pen greenPen = new Pen(Color.Green, 2f);
            Point[] pm = star5(250, 220, 25);
            g.DrawClosedCurve(greenPen, pm, 0f, FillMode.Winding);
        }

        private void незамкнутаяЛоманаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pen greenPen = new Pen(Color.Red, 2f);
            Point[] pm = star5(300, 220, 25);
            g.DrawCurve(greenPen, pm, 0f);
        }

        private void незамкнутыйСплайнToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pen pen = new Pen(RandomColor(), 2f);
            Point[] pm = star5(400, 200, 25);
            float elasticity = Convert.ToSingle(textBox1.Text);
            g.DrawCurve(pen, pm, elasticity);
        }

        private void замкнутToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pen pen = new Pen(RandomColor(), 3f);
            Point[] pm = star5(450, 200, 25);
            float elasticity = Convert.ToSingle(textBox1.Text);
            g.DrawClosedCurve(pen, pm, elasticity, FillMode.Winding);
        }

        private void однаКриваяБезьеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Point start = new Point(500, 100);
            Point control1 = new Point(500, 300);
            Point control2 = new Point(700, 300);
            Point finish = new Point(800, 100);

            g.DrawBezier(new Pen(Color.Black, 3), start, control1, control2, finish);

            SolidBrush br = new SolidBrush(Color.Green);
            Pen pen = new Pen(Color.Green, 1);

            g.FillEllipse(br, start.X - 5, start.Y - 5, 11, 11);
            g.FillEllipse(br, control1.X - 5, control1.Y - 5, 11, 11);
            g.FillEllipse(br, control2.X - 5, control2.Y - 5, 11, 11);
            g.FillEllipse(br, finish.X - 5, finish.Y - 5, 11, 11);
            g.DrawLine(pen, start, control1);
            g.DrawLine(pen, finish, control2);
        }

        private void незамкнутаяКриваяБезьеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Point start = new Point(550, 100);
            Point control1 = new Point(800, 50);
            Point control2 = new Point(560, 310);
            Point end1 = new Point(550, 300);
            Point control3 = new Point(540, 310);
            Point control4 = new Point(290, 50);
            Point end2 = new Point(540, 100);
            Point[] bezierPoint =
            {
                start, control1, control2, end1, control3, control4, end2
            };

            g.DrawBeziers(new Pen(Color.Red, 3), bezierPoint);
        }

        private void замкнутаяКриваяБезьеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Point start = new Point(500, 100);
            Point control1 = new Point(750, 50);
            Point control2 = new Point(510, 310);
            Point end1 = new Point(500, 300);
            Point control3 = new Point(500, 310);
            Point control4 = new Point(240, 50);
            Point end2 = new Point(500, 100);
            Point[] bezierPoint =
            {
                start, control1, control2, end1, control3, control4, end2
            };

            g.DrawBeziers(new Pen(Color.Yellow, 3), bezierPoint);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            SolidBrush white = new SolidBrush(Color.White);
            Rectangle rect = new Rectangle(0, 0, 2000, 2000);
            g.FillRectangle(white, rect);
        }
    }
}
