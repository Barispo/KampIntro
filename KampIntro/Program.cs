﻿using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety = tip güvenliği
            //Do not repeat yourself - Kendini tekrarlama

            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 320000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = false;
            double dolarDun = 7.45;
            double dolarBugun = 7.45;




            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış Oku");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Aartış Oku");
            }
            else
            {
                Console.WriteLine("Değişmedi Oku");
            }



            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }

            Console.WriteLine(kategoriEtiketi);

        }
    }
}

