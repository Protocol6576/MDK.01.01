using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr17_Ср1_Лихачев
{
    public partial class Form1 : Form
    {
        SolidBrush body = new SolidBrush(Color.Red);
        SolidBrush other = new SolidBrush(Color.Green);
        SolidBrush cleaner = new SolidBrush(Color.White);
        Graphics g;

        Point[] points = new Point[3];

        float speed = 0;
        float bSizeX = 25;
        float bSizeY = 200;
        float oSize = 25;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            speed += 3;

            DrawRocket();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void DrawRocket()
        {
            points[0].X = (int)(pictureBox1.Width / 2 - bSizeX); points[0].Y = (int)(pictureBox1.Height - bSizeY - speed);
            points[1].X = (int)(pictureBox1.Width / 2); points[1].Y = (int)(pictureBox1.Height - bSizeY - oSize - speed);
            points[2].X = (int)(pictureBox1.Width / 2 + bSizeX); points[2].Y = (int)(pictureBox1.Height - bSizeY - speed);

            g = pictureBox1.CreateGraphics();
            g.FillRectangle(body, pictureBox1.Width / 2 - bSizeX, pictureBox1.Height - bSizeY - speed, bSizeX*2, 200);
            g.FillPolygon(other, points);
            g.FillRectangle(cleaner, pictureBox1.Width / 2 - bSizeX, pictureBox1.Height - speed, bSizeX * 2, 20);

        }
    }
}
