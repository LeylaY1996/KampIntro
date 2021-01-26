using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    //generic class çalışcagımız öel bir type'ın 
    //olacagını belirtiyoruz
    class MyList<T>
    { 
        T[] items;

        //constructor->ilk başlangıcında çalışır
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items;
            items = new T[items.Length + 1];
        }
    }
}
