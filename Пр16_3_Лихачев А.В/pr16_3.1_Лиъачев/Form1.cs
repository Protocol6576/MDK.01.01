using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace pr16_3._1_Лиъачев
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
            Rectangle r = new Rectangle(10, 10, 100, 100);
            LinearGradientBrush theBrush = null;
            int yOffset = 10;
            Array obj = Enum.GetValues(typeof(LinearGradientMode));

            for (int x = 0; x < obj.Length; x++)
            {
                LinearGradientMode temp  = (LinearGradientMode)obj.GetValue(x);
                theBrush = new LinearGradientBrush (r, Color.GreenYellow, Color.Blue, temp);
                g.DrawString(temp.ToString(), new Font("Times Sew Roman", 10),
                    new SolidBrush(Color.Black), 0, yOffset);

                g.FillRectangle(theBrush, 150, yOffset, 200, 50);
                yOffset += 80;
            }
        }
    }
}
