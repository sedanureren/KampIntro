using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1 ?? ==30

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2; // sayılar 1 in adresini sayılar2 ninkine taşıyoruz.o yüzden 2 nin değişimleri 1 i etkiler.
            sayilar2[0] = 999;
            //sayilar1[0] ==999
            //int decimal float double bool= değer tip -> bellekte stack kısmında bulunur.
            //array class interface =referans tip -> (int[] sayilar1) bu kısım stack (new int[] { 10, 20, 30 };) bu kısım heap .new demek heap de yeni bir yer oluştur demektir
            

        }
    }
}
