using System;

namespace Kampİntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //tybe safety-tip güvenliği
            // do not repeat your self
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 3200;
            double faizOranı = 1.45;
            bool sistemeGirişYapmışMı = false;
            double dolarDun = 7.35;
            double dolarBugun=7.45;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("azalış butonu");
            }
            else if (dolarDun > dolarBugun)
            {
                Console.WriteLine("artış butonu");

            }
            else
            {
                Console.WriteLine("değişmedi butonu");
            }
            if (sistemeGirişYapmışMı==true) 
            {
                Console.WriteLine("kullanıcıayarıbutonu");            
            }
            else
            {
                Console.WriteLine("giriş yap butonu");
            }

            Console.WriteLine(kategoriEtiketi);
            Console.WriteLine(kategoriEtiketi);
            Console.WriteLine(kategoriEtiketi);


        }
    }
}
