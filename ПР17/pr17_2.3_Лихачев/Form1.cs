using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr17_2._3_Лихачев
{
    public partial class Form1 : Form
    {
        SolidBrush bgcol = new SolidBrush(Color.White);

        int cnt1 = 0;
        float speedA = 0;
        float speedB = 0;
        float speedC = 0;
        float speedD = 0;
        float speedE = 0;
        float speedF = 0;
        float speedG = 0;
        float speedH = 0;
        float speedI = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            cnt1++;

            speedA += (float)1.1;
            speedB += (float)1;
            speedC += (float)0.9;
            speedD += (float)0.8;
            speedE += (float)0.7;
            speedF += (float)0.6;
            speedG += (float)0.5;
            speedH += (float)0.4;
            speedI += (float)0.3;

            if (cnt1 == 3600)
            {
                speedA = 0;
                speedB = 0;
                speedC = 0;
                speedD = 0;
                speedE = 0;
                speedF = 0;
                speedG = 0;
                speedH = 0;
                speedI = 0;
            }

            RotatingFigures();
        }

        private void SetPiolygon(PointF center, int vertexes, float radius, Graphics graphics, Bitmap bmp, float speed)
        {
            var angle = Math.PI * 2 / vertexes;
            var points = Enumerable.Range(0, vertexes).Select(i => PointF.Add(center, new SizeF((float)Math.Sin(i * angle) * radius, (float)Math.Cos(i * angle) * radius)));

            SolidBrush transparent = new SolidBrush(Color.FromArgb(30, 255, 0, 0));

            graphics.TranslateTransform((float)pictureBox1.Width / 2, (float)pictureBox1.Height / 2);
            graphics.RotateTransform(speed);
            graphics.FillPolygon(transparent, points.ToArray());
        }

        private void RotatingFigures()
        {
            Bitmap btmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics a = Graphics.FromImage(btmp);
            Graphics b = Graphics.FromImage(btmp);
            Graphics c = Graphics.FromImage(btmp);
            Graphics d = Graphics.FromImage(btmp);
            Graphics e = Graphics.FromImage(btmp);
            Graphics f = Graphics.FromImage(btmp);
            Graphics g = Graphics.FromImage(btmp);
            Graphics h = Graphics.FromImage(btmp);
            Graphics i = Graphics.FromImage(btmp);

            g.FillRectangle(bgcol, 0, 0, 500, 500);

            SetPiolygon(new PointF(0, 0), 3, 20, a, btmp, speedA);
            SetPiolygon(new PointF(0, 0), 4, 45, b, btmp, speedB);
            SetPiolygon(new PointF(0, 0), 5, 70, c, btmp, speedC);
            SetPiolygon(new PointF(0, 0), 6, 95, d, btmp, speedD);
            SetPiolygon(new PointF(0, 0), 7, 120, e, btmp, speedE);
            SetPiolygon(new PointF(0, 0), 8, 145, f, btmp, speedF);
            SetPiolygon(new PointF(0, 0), 9, 170, g, btmp, speedG);
            SetPiolygon(new PointF(0, 0), 10, 195, h, btmp, speedH);
            SetPiolygon(new PointF(0, 0), 11, 220, i, btmp, speedI);

            pictureBox1.BackgroundImage = btmp;
        }
    }
}
