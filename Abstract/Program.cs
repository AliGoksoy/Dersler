using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Islem i = new Islem();
            i.Tur = "Kamyon";
            i.Uretim();
            Console.Read();
        }
    }
}
