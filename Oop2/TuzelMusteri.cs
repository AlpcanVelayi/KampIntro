using System;
using System.Collections.Generic;
using System.Text;

namespace Oop2
{ //Tüzel => Corporate
    class TuzelMusteri : Musteri // : Musteri yaptığımız zaman o classtan(Musteri'den) miras(inheritance) almış olursun.
    {
       
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }
    }
}
