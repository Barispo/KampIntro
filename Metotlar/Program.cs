using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string urunAdi = "Elma";
            //double fiyati = 15;
            //string aciklama = "Amasya Elması";

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 80;
            urun1.Aciklama = "Diyarbakır Karpuzu";

            Urun urun2 = new Urun();
            urun2.Adi = "Armut";
            urun2.Fiyati = 8;
            urun2.Aciklama = "Adıyaman Armutu";

            Urun urun3 = new Urun();
            urun3.Adi = "Çilek";
            urun3.Fiyati = 10;
            urun3.Aciklama = "Manisa Çileği";

            Urun[] urunler = new Urun[] { urun1, urun2, urun3 };

            foreach (var urun in urunler)
            {
                Console.WriteLine("Ürün Adı    :" + urun.Adi);
                Console.WriteLine("Ürün Fiyatı :" + urun.Fiyati + " TL ");
                Console.WriteLine("Ürün Menşei :" + urun.Aciklama);
                Console.WriteLine("------------------------------------");
                Console.WriteLine("");

            }

            Console.WriteLine("------------------------METODLAR----------------------");
            Console.WriteLine("");

            //instance - örnek(class örneği)
            //encapsulation
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            sepetManager.Ekle(urun3);

            Console.WriteLine("");
            Console.WriteLine("-------------Encapsulation Örneği aşağıdaki gibidir-----");
            Console.WriteLine("");

            sepetManager.Ekle2("Armut", "Yeşil Armut", 12, 4);
            sepetManager.Ekle2("Elma", "Yeşil Elma", 12, 4);
            sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 12, 7);
        }

    }
}