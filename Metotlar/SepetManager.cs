using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //naming convention - kodun okunurluğu için önemli !
        //syntax
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Sepete Eklendi TEBRİKLER! : " + urun.Adi);

        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi : " + urunAdi);
        }
    }
}
