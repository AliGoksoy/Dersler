using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            int deger = 3;

            switch (deger)
            {
               
                case 1:
                    Console.WriteLine("Girilen değer :" + deger);
                    break;
                case 2:
                    Console.WriteLine("Girilen değer :" + deger);
                    break;
                case 3:
                    Console.WriteLine("Girilen değer :" + deger);
                    break;

                case 4:
                    Console.WriteLine("Girilen değer :" + deger );
                    break;
                case 5:
                    Console.WriteLine("Girilen değer :" + deger);
                    break;
              default:
                  Console.WriteLine("Girilen değer bulunamdı.");
                    break;
                  
              
            }

            Console.Read();
        }
    }
}
