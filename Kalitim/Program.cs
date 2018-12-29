using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim
{
    class Program
    {
        static void Main(string[] args)
        {

            Insan i = new Insan();
            i.Ad = "Cemal";
            i.Soyad = "Deniz";
            Console.WriteLine(i.NesneOlustur()+ "Adında bir insan oluşturuldu.");



            Erkek e = new Erkek(true);
            e.Ad = "Hasan";
            e.Soyad = "Yilmaz";
            Console.WriteLine(e.NesneOlustur()+ "Adında bir insan oluşturuldu.");


            Kadin k = new Kadin(false);
            k.Ad = "Selin";
            k.Soyad = "Atmaca";
            Console.WriteLine(k.NesneOlustur() + "Adında bir insan oluşturuldu.");

          Console.WriteLine("*****************************************");

            C c = new C();
           
  
            Console.Read();

        }


        //Farklı bir örnek ile ele alırsak

        class  A
        {
            //A Sınıfındaki constructer parametre alıyor olsaydı eger, diger sınfılara :base olarak paramete degeri gönderebilirz.

            public A()
            {
                Console.WriteLine("A Sınıfı");
            } 
        }
        class B:A
        {
            public B()
            {
                Console.WriteLine("B Sınıfı");
            }
        }
        class C:B
        {
            public C()
            {
                Console.WriteLine("C Sınıfı");
            }
        }

    }
}
