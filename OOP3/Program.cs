using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();//IhtiyacKredisi yerine IKrediManager de yazılabilir.
            ihtiyacKrediManager.Hesapla();

            TaşıtKrediManager taşıtKrediManager = new TaşıtKrediManager();
            taşıtKrediManager.Hesapla();

            KonutKrediManager konutKrediManager = new KonutKrediManager();
            konutKrediManager.Hesapla();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileloggerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(ihtiyacKrediManager, databaseLoggerService);

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager, taşıtKrediManager};

           // basvuruManager.KrediOnBilgilendirmesiYap(krediler);




        }
    }
}
