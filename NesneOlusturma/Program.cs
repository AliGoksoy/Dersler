using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneOlusturma
{
    class Program
    {
        static void Main(string[] args)
        {

            //Deger tipi ve referans tipindeki degiskenler Ram Stack kısmında oluşmaktadır.
            //Referans tipindeki degişken ise Stack kısmında referans noktası oluşturarak Heap kısmında nesne üretmektedir.
            //Heap içerisinde  bulunmayan neslerin stack kısmında referans noktası bulunmadığı taktirde Gc Gabric Collection belirli aralıklarda temizleyecektir.




            Ornek o = new Ornek();  //Stack kısmında o referans noktası oluşturarak heap kısmında ornek nesneri üretmektedir.
            Ornek y = o; //o tipi Ornek tipine eşit oldugu için y = o demek aynı nesne demektir.

            if (o.Equals(y))
            {
                Console.WriteLine("Eşit");
            }
            else
            {
                Console.WriteLine("Eşit değil");
            }

            Console.Read();


        }
    }
}
