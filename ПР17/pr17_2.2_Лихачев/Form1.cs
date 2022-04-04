using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr17_2._2_Лихачев
{
    public partial class Form1 : Form
    {
        Graphics gr;
        SolidBrush fon;
        SolidBrush fig;

        int rad;
        Random rand;

        Pen p = new Pen(Color.Lime);

        public Form1()
        {
            InitializeComponent();
        }

        void DrawCircle(int x, int y)
        {
            int xc, yc;
            xc = x - rad;
            yc = y - rad;
            gr.FillEllipse(fig, xc, yc, rad, rad);
            gr.DrawEllipse(p, xc, yc, rad, rad);
            
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            gr = pictureBox1.CreateGraphics();
            fon = new SolidBrush(Color.Black);
            fig = new SolidBrush(Color.Purple);

            rad = 40;
            rand = new Random();

            gr.FillEllipse(fon, 0, 0, pictureBox1.Width, pictureBox1.Height);

            int x, y;

            for (int i = 0; i < 15; i++)
            {
                x = rand.Next(pictureBox1.Width);
                y = rand.Next(pictureBox1.Height);
                DrawCircle(x, y);
            }
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            gr.FillRectangle(fon, 0, 0, pictureBox1.Width, pictureBox1.Height);

            int x, y;

            for (int i = 0; i < 15; i++)
            {
                x = rand.Next(pictureBox1.Width);
                y = rand.Next(pictureBox1.Height);
                DrawCircle(x, y);
            }
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            fon = new SolidBrush(Color.White);
            gr.FillRectangle(fon, 0, 0, pictureBox1.Width, pictureBox1.Height);
        }
    }
}
