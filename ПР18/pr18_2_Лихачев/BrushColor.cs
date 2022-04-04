using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;

namespace pr18_2_Лихачев
{
    public class BrushColor
    {
        public Color FonColor;
        public Color laserColor;
        public Color DashBug;
        public Color KilledBug;

        public BrushColor()
        {

        }

        public HatchBrush New_br(int rch)
        {
            return new HatchBrush(HatchStyle.DashedUpwardDiagonal, DashBug, RandomColor(rch));
        }


        public void HatchBrushNew(int rch)
        {

        }

        public Color RandomColor(int rch)     
        {
            int r, g, b;
            byte[] bytes1 = new byte[3];      
            Random rnd1 = new Random(rch);
            rnd1.NextBytes(bytes1);          
            r = Convert.ToInt16(bytes1[0]);
            g = Convert.ToInt16(bytes1[1]);
            b = Convert.ToInt16(bytes1[2]);
            return Color.FromArgb(r, g, b);   
        }

    }


}
