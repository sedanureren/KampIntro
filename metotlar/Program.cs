using System;

namespace metotlar
{
    class Program
    {

        static void Main(string[] args)
        {
            string urunAdi = "ELMA";
            double fiyati = 15;
            string aciklama = "amasya elması";

            string[] meyveler = new string[] { };

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi= "karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "diyarbakır karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (Urun urun in urunler)//in urunler kısmı urunler dizisini tek tek gezer. urun kısmı ise o anki elemana takma isim verir urun yerine x de verilebilir önemli değil.Urun veri tipidir var da yazılabilir.
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-----------------");
            

            }

            Console.WriteLine("-----METOTLAR------");
            
            //encapsulation-düzensiz bir yapıyı düzenli hale getirmek - kapsülleme

            //instance-örnek

            sepetManager SepetManager = new sepetManager();
          
            SepetManager.Ekle(urun1);
            SepetManager.Ekle(urun2);

            SepetManager.Ekle2("Armut", "yeşil armut", 12,10);
            SepetManager.Ekle2("Elma", "yeşil elma", 12,9);
            SepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 12,8);
        }
    }
}
