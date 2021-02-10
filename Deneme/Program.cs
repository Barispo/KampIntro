using System;

namespace Deneme
{
    class Program
    {
        static void Main(string[] args)
        {
            Sabit sabit_Bilgiler1 = new Sabit ();
            sabit_Bilgiler1.Adi = "Barış";
            sabit_Bilgiler1.Soyadi = "PİŞMİŞOĞLU";
            sabit_Bilgiler1.Yasi = 47;
            sabit_Bilgiler1.AldigiNot = 89;

            Sabit [] sabit_Bilgiler = new Sabit [] { sabit_Bilgiler1 };
            foreach (var SB in sabit_Bilgiler)
            {
                Console.WriteLine("Öğrencinin Adı / Soyadı : " + SB.Adi+ "/"+ SB.Soyadi);
                Console.WriteLine("Öğrencinin Yaşı / Notu : " + SB.Yasi + "/" + SB.AldigiNot);
            }
            


        }





    }
    class Sabit
    {
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public int Yasi { get; set; }
        public int AldigiNot { get; set; }

    }



}
