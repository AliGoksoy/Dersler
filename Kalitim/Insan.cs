using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim
{
    public class Insan
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }

        public virtual string NesneOlustur()
        {
          return  string.Format("{0} {1} ", Ad,Soyad);
        }
    }
}
