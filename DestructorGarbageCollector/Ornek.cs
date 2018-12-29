using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DestructorGarbageCollector
{
   public class Ornek
   {
        int sayi;
        public Ornek(int id) //Yapıcı metod
        {
            sayi = id;
            Console.WriteLine(sayi + " - Nesne üretildi.");
        }

        ~Ornek() //Yıkıcı metod
        {

            Console.WriteLine(sayi + " - Nesne silindi.");
        }


   
    }
}
