using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;  
        //constructor
        public MyList()// amacı arrayı 0 da new leyip Add de kullanabilmek.
        {
            items = new T[0]; //arraylerin new lenme sorumluluğu var.
        }
        public void Add(T item)
        {
            T[] tempArray = items; //new dediğimizde referans numarası kaybolduğu için referans numarasını başkasına tutturuyorum.
            items = new T[items.Length+1];//items.Lenght=dizinin eleman sayısı
            for (int i = 0; i < tempArray.Length; i++)//emaneten cerdiğimiz arrayleri geri almak için yapıyoruz.
            {
                items[i] = tempArray[i];
            }
            items[items.Length - 1 ]= item;
        }


    }
}
