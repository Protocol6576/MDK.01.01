using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr19_3_Likhachev_Miroshnichenko
{
    class Program
    {
        class Square
        {
            private int height;
            private int width;

            public int Width { get => width; set => width = value; }
            public int Height { get => height; set => height = value; }
        }

        class MainClass
        {
            static void Main(string[] args)
            {
                Square mySquare = new Square();
                mySquare.Width = 100;
                mySquare.Height = 150;
                Console.WriteLine("width = {0}", mySquare.Width);
                Console.WriteLine("height = {0}", mySquare.Height);
            }
        }

        
    }
}
