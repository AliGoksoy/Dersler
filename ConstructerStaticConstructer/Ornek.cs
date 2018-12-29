using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructerStaticConstructer
{
   public class Ornek
    {
        public int deger { get; set; }
        public Ornek()
        {
            Console.WriteLine("Buda çalıştı");
        }

        public Ornek(int sayi)
        {
            Console.WriteLine("Sayi: ",sayi);
        }

        static Ornek()
        {
            Console.WriteLine("İlk bu çalıştı");
        }
    }
}
