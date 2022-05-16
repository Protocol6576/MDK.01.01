using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr19_1._3_Likhachev_Miroshnichenko
{
    class Program
    {
        delegate void D();
        D d;

        static void Main(string[] args)
        {
            Program p = new Program();
            int i = 10;
            i = Delegating(p, i);
            i++;
            p.d();
            Console.ReadLine();
        }

        private static int Delegating(Program p, int i)
        {
            /*начать извлечение*/
            p.d = delegate { Console.WriteLine(i++); };
            /*закончить извлечение*/
            return i;
        }
    }
}
