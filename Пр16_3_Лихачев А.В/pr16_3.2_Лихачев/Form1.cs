using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr16_3._2_Лихачев
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(500, 500);
            this.DoubleBuffered = true;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            int num = 300;
            int cx = ClientSize.Width;
            int cy = ClientSize.Height;
            Pen pen = new Pen(Color.Red);
            PointF[] aptf = new PointF[4];
            for (int i = 0; i < num; i++)
            {
                double dAngle = 2 * i * Math.PI / num;
                aptf[0].X = cx / 2 + cx / 2 * (float)Math.Cos(dAngle);
                aptf[0].Y = 5 * cy / 8 + cy / 16 * (float)Math.Sin(dAngle);
                aptf[1] = new PointF(cx / 2, -cy);
                aptf[2] = new PointF(cx / 2, 2 * cy);
                dAngle += Math.PI;
                aptf[3].X = cx / 2 + cx / 4 * (float)Math.Cos(dAngle);
                aptf[3].Y = cy / 2 + cy / 16 * (float)Math.Sin(dAngle);
                g.DrawBeziers(pen, aptf);
            }
        }
    }
}
