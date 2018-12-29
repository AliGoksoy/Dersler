using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    class Program
    {
        static void Main(string[] args)
        {

            Ogrenciler ogrenci = new Ogrenciler();
            ogrenci[1] = "Deniz";
            ogrenci[2] = "Selim";
            ogrenci[3] = "Ayla";


            Console.WriteLine(ogrenci[2]);

            Console.Read();
        }


     
    }
}
