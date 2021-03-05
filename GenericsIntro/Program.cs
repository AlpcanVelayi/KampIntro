using System;
using System.Collections.Generic;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Alpcan");
            

            List<string> liste = new List<string>();
            Console.WriteLine(liste.Count);
            //classı yani MyList'i burada newlediğin anda dizi oluşturmak istiyorsan constructor yapısını kullanıyorsun
        }
    }
}
