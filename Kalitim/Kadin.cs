using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim
{
   public class Kadin:Insan
   {
        string Makyajlimi;

        public Kadin(bool tip)
        {
            if (tip == true)
            {
                this.Makyajlimi = "Makyajlı";
            }
            else
            {
                this.Makyajlimi = "Makyajsız";
            }

        }

        public override string NesneOlustur()
        {
            return string.Format("{2} {0} {1}  ", Ad, Soyad, Makyajlimi);
        }

   

        
   }
}
