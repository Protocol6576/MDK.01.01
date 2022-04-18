using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr19_1_Likhachev_Miroshnichenko
{
    class Program
    {
        const double PI = 3.141592;

        double CalculatePaintNeeded(double paintPerUtin, double radius)
        {
            double area = CircleArea(radius);

            return area / paintPerUtin;
        }

        private static double CircleArea(double radius)
        {
            return PI * radius * radius;
        }
    }
}
