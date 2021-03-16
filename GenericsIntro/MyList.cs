using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    // <T> => bana tip ver ben aşağıyı ona göre düzenleyeceğim demek
    class MyList<T>
    {
        T[] items;
        //constructor alttaki aslında bir metottur, classın ismiyle aynıdır. Classı bir yerde new'lediğin zaman constructorda otomatik çalışır. Kısayolu "ctor"
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)  
        {
            T[] tempArray = items;
            items = new T[items.Length+1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;
        }
        public int Length
        {
            get { return items.Length; }
        }
        
    }
}
