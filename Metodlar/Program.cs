using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodlar
{
    class Program
    {
        static void Main(string[] args)
        {


            Toplama toplama = new Toplama();
  

            Console.WriteLine("İşlem 1: " + toplama.Topla(20, 30));
            Console.WriteLine("İşlem 2: " + toplama.Topla(20, 30, 40));

            Console.Read();
        }




    
    }
}
