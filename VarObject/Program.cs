using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarObject
{
    class Program
    {
        static void Main(string[] args)
        {


            #region  Var Değişken Tipi

            //Var degişken tipi diger deger tiplerinin aksine atanmış olan değerin türüne bürünür. Örnek int deger tipine sayı atanması gerekiyor iken string yani atama işlemi yapılamaz.
            //Var tipi bunun aksine hangi degeri atarsak o degerin tipini alır.

            int sayi = 123;
            int sayi2 = 123;
            string yazi = "Yazi";
            var degisken = sayi;
            var degisken2 = yazi;
        

            //degisken = degisken2;  Değişken degeri int oldugu ve degişken2 string oldugu için işlem hata vermektedir.


            #endregion

            #region  Object
            //Csharp dilinde hersey objecten türemektedir.
            //Object var tipinin aksine atanan degeri object olarak tutar var tipi gibi atanan değerin tibipi almaz.
            //Object tibinde tutulan veri Boxing ve Unboxing işlemine tabi tutulur.

            object degisken3 = 1; // degisken3 object türündedir ve boxing işlemine tabi tutulmuştur.

            int degisken4 = (int) degisken3; // değişken3'ü int cascading yaparak int tipine dönüştüyoruz yani object tipinde boxing olan veriyi unboxing yapıyoruz.

            #endregion






        }
    }
}
