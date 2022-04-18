using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr19_6_Likhachev_Miroshnichenko
{
    class ProtoClassA
    {
        public void MethodB(bool b, int i) { }
    }
    class ProtoClassC
    {
        void D()
        {
            ProtoClassA MyClassA = new ProtoClassA();
            MyClassA.MethodB(false, 0);
        }
    }
}
