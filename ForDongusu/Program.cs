using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForDongusu
{
    class Program
    {
        static void Main(string[] args)
        {
            int baslangicDegeri = 10;
            int bitisDegeri = 50;
            int artilacakDeger = 5;

            for (int i = baslangicDegeri; i < bitisDegeri; i+=artilacakDeger)
            {              
                    Console.WriteLine("Şimdi " + i);
                        
            }

            Console.Read();
        }
    }
}
