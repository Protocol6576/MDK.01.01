using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr16_3._4_Лихачев
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap canvas = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics graphCanvas = Graphics.FromImage(canvas);

            PointF centerDrawing = new PointF(canvas.Width / 2, canvas.Height / 2);
            int minx = int.Parse(textBox1.Text), maxx = int.Parse(textBox2.Text);
            
            float stepX = canvas.Width / Math.Abs(maxx - minx);
            float stepY = canvas.Height / maxx.CompareTo(maxx - minx);

            DrawAxis(graphCanvas, Color.Black, centerDrawing, canvas.Size, minx, maxx, stepX, stepY);

            List<PointF> func1 = CreateFunc1(minx, maxx, 0.0001f);
            List<PointF> func2 = CreateFunc2(minx, maxx, 0.0001f);

            DrawCurve(graphCanvas, Brushes.Magenta, func1, centerDrawing, stepX, stepY);
            DrawCurve(graphCanvas, Brushes.Red, func2, centerDrawing, stepX, stepY);

            pictureBox1.Image = canvas;
        }

        void DrawAxis(Graphics canvas, Color Color, PointF Center, Size drawingField, float min, float max, float stepX, float stepY)
        {
            Pen axisPen = new Pen(Color, 2);
            canvas.DrawLine(axisPen, new PointF(0, drawingField.Height / 2.0f), new PointF(drawingField.Width, drawingField.Height / 2.0f));
            canvas.DrawLine(axisPen, new PointF(drawingField.Width / 2.0f, 0), new PointF(drawingField.Width / 2.0f, drawingField.Height));
        }

        void DrawCurve(Graphics canvas, Brush Color, List<PointF> dataPoint, PointF Center, float stepX, float stepY)
        {
            dataPoint.ForEach(new Action<PointF>((o) =>
            {
                canvas.FillEllipse(Color, new RectangleF(new PointF((o.X * stepX + Center.X) - 1, (o.Y * stepY + Center.Y) - 1), new SizeF(2, 2)));
            }));

        }

        List<PointF> CalcFunc(Func<float, float> func, float min, float max, float step)
        {
            List<PointF> _result = new List<PointF>();
            for (float x = min; x < max; x += step)
            {
                _result.Add(new PointF(x, func(x)));
            }
            return _result;
        }

        List<PointF> CreateFunc1(float min, float max, float step)
        {
            return CalcFunc(new Func<float, float>((x) => {
                return
                (float)(Math.Pow(Math.Abs(x), 5) * ( 1 / (Math.Tan(Math.Abs(x)))));
            }), min, max, step);
        }

        List<PointF> CreateFunc2(float min, float max, float step)
        {
            return CalcFunc(new Func<float, float>((x) => {
                return(float)(Math.Log(x*x + 1));
            }), min, max, step);
        }



        /* --==={|/\/\/\/\/\/\/\|}===-- */



        private double XMin, XMax, Step; //
        private double[] x, y1, y2, y3;

        private void button2_Click(object sender, EventArgs e)
        {
            XMin = double.Parse(textBox1.Text);
            XMax = double.Parse(textBox2.Text);
            Step = double.Parse(textBox3.Text);
            CalcFunction();

            chart1.ChartAreas[0].AxisX.Minimum = XMin;
            chart1.ChartAreas[0].AxisX.Maximum = XMax;

            chart1.ChartAreas[0].AxisX.MajorGrid.Interval = Step;
            chart1.Series[0].Points.DataBindXY(x, y1);
            chart1.Series[1].Points.DataBindXY(x, y2);
            chart1.Series[2].Points.DataBindXY(x, y3);
        }

        private void CalcFunction()
        {
            int count = (int)Math.Ceiling((XMax - XMin) / Step) + 1;

            x = new double[count];
            y1 = new double[count];
            y2 = new double[count];
            y3 = new double[count];

            for (int i = 0; i < count; i++)
            {
                x[i] = XMin + Step * i;
                y1[i] = (float)(Math.Pow(Math.Abs(x[i]), 5) * (1 / (Math.Tan(Math.Abs(x[i])))));
                y2[i] = (float)(Math.Log(Math.Pow(x[i], 2) + 1));
                y3[i] = (float)(1 - Math.Pow(Math.Abs(x[i] + 1), (double)(1 / 2)));
            }
        }
    }
}
