using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr19_2_Likhachev_Miroshnichenko
{
    class Program
    {
        class ProtocolClassA
        {
            // Вызвать метод 'MethodC'

            public void MethodC(int i, bool b) { }
        }

        class ProtocolClassC
        {
            void D()
            {
                ProtocolClassA MyClassA = new ProtocolClassA();

                MyClassA.MethodC(0, false);
            }
        }
    }
}
