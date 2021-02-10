using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1 ?? 30 olur, sayi2 65'e eşitlendikten sonra sayi bir 30'u, sayi2 ise 65'i tutmaya başlar.


            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar1[0] cevap 999 olacaktır.

            //int, decimal, float, double, bool ===> DEĞER TİPLER
            //array, class, interface ===> REFERANS TİPLER

            //STACK                                                                                        HEAP
            //sayi1 = 10 (30 olur)
            //sayi2 = 30 (65 olur)

            //sayilar1 dendiğinde stack'ta        örn.101 gibi bir bellek adresinde tutulur                101/[10,20,30] şeklinde tutuyor   
            //sayiler2 tanımlayıp new dediğinde   örn.102 gibi bir bellekte adres oluşturur                102/[100,200,300] şeklinde tutuyor
            
            //sayilar1=sayilar2 yapıldığında ise sayilar1'in 101 olan bellek adresi, 102 olarak değişiyor ve sayilar1'in[0] elemanı sayilar2'nin 102 olan adresindeki, 
            //sayilar2'nin [o] elemanı 999' eşit olduğu için cevap 999 olacaktır.
        }
    }
}
