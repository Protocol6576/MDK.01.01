using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr17_Ср2_Лихачев
{
    public partial class Form1 : Form
    {
        int counter = 0;

        SolidBrush body = new SolidBrush(Color.Yellow);
        SolidBrush other = new SolidBrush(Color.Red);
        SolidBrush eye = new SolidBrush(Color.Black);

        Point[] brovi1 =
        {
            new Point(230, 100),
            new Point(240, 80),
            new Point(260, 80),
            new Point(270, 100),
        };

        Point[] brovi2 =
        {
            new Point(230, 100),
            new Point(250, 80),
            new Point(270, 100),
        };

        Point[] smile =
        {
            new Point(150, 200),
            new Point(250, 200),
            new Point(270, 260),
            new Point(130, 260),
        };

        Graphics g;

        public Form1()
        {
            InitializeComponent();
            g = pictureBox1.CreateGraphics();
        }

        private void drawButton_Click(object sender, EventArgs e)
        {
            g.FillRectangle(new SolidBrush(Color.White), 0, 0, pictureBox1.Width, pictureBox1.Height);
            DrawFace1();
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;
            
            if(counter == 150)
            {
                g.FillRectangle(new SolidBrush(Color.White), 0, 0, pictureBox1.Width, pictureBox1.Height);
                DrawFace2();
            }
        }

         private void DrawFace1()
         {
            g.FillEllipse(body, 100, 100, 200, 200);

            g.FillEllipse(other, 150, 185, 100, 100);
            g.FillEllipse(body, 150, 170, 100, 100);

            g.FillEllipse(eye, 150, 130, 20, 20);
            g.FillEllipse(eye, 230, 130, 20, 20);

            g.DrawBeziers(new Pen(Color.Black, 3), brovi1);
            for (int i = 0; i < 4; i++) { brovi1[i].X -= 100; };
            g.DrawBeziers(new Pen(Color.Black, 3), brovi1);
            for (int i = 0; i < 4; i++) { brovi1[i].X += 100; };
        }

         private void DrawFace2()
         {
            g.FillEllipse(body, 100, 100, 200, 200);

            g.FillPolygon(other, smile);
            g.FillRectangle(new SolidBrush(Color.White), 155, 205, 90, 10);
            g.FillRectangle(new SolidBrush(Color.White), 145, 245, 110, 10);

            g.FillEllipse(eye, 150, 130, 20, 20);
            g.FillEllipse(eye, 230, 130, 20, 20);

            g.DrawCurve(new Pen(Color.Black, 3), brovi2);
            for (int i = 0; i < 3; i++) { brovi2[i].X -= 100; };
            g.DrawCurve(new Pen(Color.Black, 3), brovi2);
            for (int i = 0; i < 3; i++) { brovi2[i].X += 100; };
        }
    }
}
