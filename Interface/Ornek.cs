using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Ornek : IIslemler
    {
        public void Mesa()
        {
           Console.WriteLine("Interface Mesajı");
        }

        public int Toplama(int a, int b)
        {
            return a + b;
        }
    }
}
