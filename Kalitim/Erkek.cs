using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim
{
   public class Erkek:Insan
   {
       private string SakaliMi;

        public Erkek(bool tip)
        {
            if (tip==true)
            {
                this.SakaliMi = "Sakallı";
            }
            else
            {
                this.SakaliMi = "Sakalsız";
            }

        }

        public override string NesneOlustur()
        {
            return string.Format("{2} {0} {1}  ", Ad, Soyad, SakaliMi);
        }
   }
}
