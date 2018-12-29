using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
   public class Islem:Ornek
   {
       public string Tur;
        public override void Uretim()
        {
            Console.WriteLine( Tur + " Üretildi.");
        }
    }
}
