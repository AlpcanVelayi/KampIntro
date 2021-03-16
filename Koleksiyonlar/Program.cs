using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //arraylar oluşturduğun boyut içinde var olur dışına taşamaz 
            //string[] isimler = new string[] {"Engin","Murat", "Kerem", "Halil"};
            //Console.WriteLine(isimler[0]); 
            //Console.WriteLine(isimler[1]); 
            //Console.WriteLine(isimler[2]); 
            //Console.WriteLine(isimler[3]);

            // burda isimleri sen yeni bir heap adresine gönderdin isimlerin 4. idsi ilker olurken diğerleri boş kaldı
            //isimler = new string[5]; 
            //isimler[4] = "İlker";
            //Console.WriteLine(isimler[4]); 
            //Console.WriteLine(isimler[0]);


            //List<string> isimler2 = new List<string>(); //listeye eleman yazmak için ' new List<string> {elemanlar burada olacak } ' bu yöntemi de kullanabilirsin
            List<string> isimler2 = new List<string> { "Engin", "Murat", "Kerem", "Halil" };
            //isimler2.Add("Alpcan"); //listeye ekledin alpcanı
            // Listler birer classtır aslında zaten renginin yeşil olmasından anlayabilirsin.
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("Alpcan");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);  

        }
    }
}
