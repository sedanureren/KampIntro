﻿using System;

namespace classİntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "engin";
            int yas = 36;
           
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Kerem";
            kurs2.IzlenmeOrani = 64;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Berkay";
            kurs3.IzlenmeOrani = 80;

           // Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3 };

            foreach (var Kurs in kurslar)
            {
                 Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmen);
            }

        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }

        public string  Egitmen { get; set; }
        
        public int IzlenmeOrani { get; set; }
    }
}
