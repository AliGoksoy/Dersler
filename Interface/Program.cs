using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {

            Ornek o = new Ornek();
            o.Mesa();
            Console.WriteLine(o.Toplama(5,4));
            Console.Read();
        }
    }
}
