using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.Write("Bir sayısal ifade giriniz: ");
                int girilenDeger = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Teşekürler, Girmiş olduğunuz değer: "+girilenDeger);
            }
            catch (Exception e)
            {
                //Console.WriteLine(e);
                Console.WriteLine("Lütfen sayısal biçimde değer giriniz.");
            }


            Console.Read();
        }
    }
}
