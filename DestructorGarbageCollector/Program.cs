using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DestructorGarbageCollector
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                new Ornek(i);
            }

            Console.WriteLine("____________________________");

            GC.Collect();

            Console.Read();
        }
    }
}
