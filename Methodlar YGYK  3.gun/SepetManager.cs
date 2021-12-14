using System;
using System.Collections.Generic;
using System.Text;

namespace Methodlar_YGYK__3.gun
{
    class SepetManager
    {
        //naming convention
        //normal parantez olan yerlerde method vardır.
        //syntax(yazım şekilleri)
        public void Ekle(Urun urun)
        {
            Console.WriteLine(" Tebrikler. Sepete eklendi:" + urun.Adi);
        }
        public void ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Tebrikler, sepete eklendi: " + urunAdi);
        }


    }
}
