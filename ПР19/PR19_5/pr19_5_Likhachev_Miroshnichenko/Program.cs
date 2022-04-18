using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr19_5_Likhachev_Miroshnichenko
{
    class Program
    {
        class A
        {
            // Вызвать для 'A'
            public A(string s) { }
        }

        class B
        {
            void C()
            {
                // Вызватьб для 'A'
                A a = new A("a");
            }
        }
    }
}
