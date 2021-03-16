using System;

namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Engin Demiroğ
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "Demiroğ";
            musteri1.TcNo = "12345678910";

            //Kodlama.io
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "1234567890";

            //Gerçek(Bireysel) Müşteri - Tüzel(Şirket) Müşteri
            //SOLID => yazılım geliştirme aşamaları

            Musteri musteri3 = new GercekMusteri(); // new dediğimiz zaman referans noyu kastediyoruz ve burdan göründügü üzere Musteri classı hem GercekMusteri'nin
            Musteri musteri4 = new TuzelMusteri();  //hem de TuzelMusteri'nin referans numarasını tutabiliyor inheritance sayesinde.

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(musteri1);
            customerManager.Add(musteri2);


        }
    }
}
