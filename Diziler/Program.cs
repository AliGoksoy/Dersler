using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler
{
    class Program
    {
        static void Main(string[] args)
        {




            //string[] ogrenciler = new[] {"Selim", "Didem", "Ayşe"};
            //foreach (var eleman in ogrenciler)
            //{
            //    Console.WriteLine("Ögrenci Adı: "+ eleman);
            //}



            int[] yaslar = new int[4];
            yaslar[0] = 17;
            yaslar[1] = 36;
            yaslar[2] = 5;
            yaslar[3] = 78;

            for (int i = 0; i < yaslar.Length; i++)
            {
                Console.WriteLine((i+1) +" sıradaki kişininin yaşı :"+yaslar[i]);
            }

            Console.Read();
        }
    }
}
