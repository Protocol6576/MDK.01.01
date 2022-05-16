using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr19_1._2_Likhachev_Miroshnichenko
{
    class Program
    {
        static void Main(string[] args)
        {
            MyConfigCUI();
            Console.ReadLine();
        }

        private static void MyConfigCUI()
        {
            Console.Title = "Мое приложение";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("Привет, это мой проект!");
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}
