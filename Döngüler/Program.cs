using System;

namespace Döngüler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "yazılım geliştirici";
            string kurs2 = "temel kurs";
            string kurs3 = "Java";

            string[] kurslar = new string[] {"yazılım geliştir","temel kurs","java" };

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            
            Console.WriteLine("forbitti");
           
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa sonu-footer");
        

        
            
        }
    }
}
