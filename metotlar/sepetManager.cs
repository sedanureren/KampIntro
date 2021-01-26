using System;
using System.Collections.Generic;
using System.Text;

namespace metotlar
{
    class sepetManager
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler.Sepete Eklendi: " + urun.Adi);


        }

        public void Ekle2(string urunAdi,string aciklama, double fiyat, int StokAdedi)
        {
            Console.WriteLine("tebrikler.Sepete eklendi:" + urunAdi);
        }
        
    
    }

}
