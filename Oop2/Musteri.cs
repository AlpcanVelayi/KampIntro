using System;
using System.Collections.Generic;
using System.Text;

namespace Oop2
{
    class Musteri //classlarda özellik tuttugumuz yerde operasyon(metot) tutmuyoruz, operasyon tuttuğumuz yerde özellik tutmuyoruz,
                  //MusteriNo, TcNo gibi sayısal değerlerin başına string koyduk çünkü eğer matematiksel işlem yapılmayacaksa uyumluluk açısından daha yararlı olur
                  //Mesela TcNo'yu int verip sonrasında excele attıgın zaman uyumsuzluk oldugu için anlamsız şeyler yazar, o yüzden metinsel vermek daha mantıklıdır
                  //***Eğerki bir nesnede bir değeri kullanmak zorunda gibi görünmüyorsan, demekki orada soyutlama hatası vardır
    {

        public int Id { get; set; }
        public string MusteriNo { get; set; }
    }
}
