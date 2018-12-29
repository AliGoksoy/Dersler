using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    public class Ogrenciler
    {
        string[] Isimler = new string[10];

        public string this[int i]
        {

            get { return Isimler[i]; }
            set {  Isimler[i] = value; }

        }
    }
}
