using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructerStaticConstructer
{
    class Program
    {
        static void Main(string[] args)
        {
            Ornek ornek = new Ornek(10);
            Ornek ornek1 = new Ornek();
            Ornek ornek2 = new Ornek();
            Console.Read();
        }
    }
}
