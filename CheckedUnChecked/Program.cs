using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckedUnChecked
{
    class Program
    {
        static void Main(string[] args)
        {





            //Checked tür değişimi esnasında veri kaybı oldugunda hata vermesini sağlanacaktır.
            //Degişkenlerde atanan verilerin değer gereksiz değer kontroleri için kullanılmaktadır.
            //Varsıylan olarak bir değişken tanımladığımızda Unchecked olmaktadır.

         

            //checked
            //{
            //    int deger4 = 1560;
            //    byte deger5 = (byte) deger4;
            //    Console.WriteLine(deger5);
            //}

            unchecked
            {
                int deger = 1255;
                byte deger2 = (byte)deger;
                Console.WriteLine(deger2);

            }



            Console.Read();


        }
    }
}
