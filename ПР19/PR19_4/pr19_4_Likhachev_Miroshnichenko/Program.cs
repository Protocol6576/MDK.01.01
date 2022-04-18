using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr19_4_Likhachev_Miroshnichenko
{
    class Program
    {
        // Вызвать интерфейс извлечения на ProtoA
        // Примечание: извлеченный интефрейс будет создан в новом файле

        class ProtoA : IProtoA
        {
            public void MethodB(string s) { }
        }
    }
}
