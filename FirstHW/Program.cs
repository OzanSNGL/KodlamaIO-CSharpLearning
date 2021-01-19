using System;

namespace FirstHW
{
    class Program
    {
        static void Main(string[] args)
        {
            Urunx urun1 = new Urunx();
            urun1.markaAdi = "Riccon";
            urun1.urunAdi = "Siyah Unisex Sneaker";
            urun1.urunFiyat = 179.04;
            urun1.urunIndirim = true;
            urun1.urunTip = "Unisex";

            Urunx urun2 = new Urunx();
            urun2.markaAdi = "Bershka";
            urun2.urunAdi = "Dikiş Detaylı Spor Ayakkabı";
            urun2.urunFiyat = 118.95;
            urun2.urunIndirim = false;
            urun2.urunTip = "Erkek";


            Urunx urun3 = new Urunx();
            urun3.markaAdi = "MUGGO";
            urun3.urunAdi = "Unisex Sneaker Ayakkabı";
            urun3.urunFiyat = 119.80;
            urun3.urunIndirim = false;
            urun3.urunTip = "Unisex";

            Urunx urun4 = new Urunx();
            urun4.markaAdi = "HUMMEL";
            urun4.urunAdi = "Porter Ayakkabı";
            urun4.urunFiyat = 293.0;
            urun4.urunIndirim = true;
            urun4.urunTip = "Kadın";

            Urunx[] erkekUrun = new Urunx[] { urun1, urun2, urun3 };
            Urunx[] kadinUrun = new Urunx[] { urun1, urun3, urun4 };

            Urunx[] urunler = new Urunx[] { urun1, urun2, urun3, urun4 };

            Console.WriteLine("Erkek Ürünleri:");

            int a = 0;
            while (a < erkekUrun.Length)
            {
                Console.WriteLine(erkekUrun[a].markaAdi + " " + erkekUrun[a].urunAdi);
                a++;
            }


            Console.WriteLine("------------------------------------");


            Console.WriteLine("Kadın Ürünleri:");

            int b = 0;
            while (b < kadinUrun.Length)
            {
                Console.WriteLine(kadinUrun[b].markaAdi + " " + kadinUrun[b].urunAdi);
                b++;
            }


            Console.WriteLine("------------------------------------");

            Console.WriteLine("İndirimdeki Erkek Ürünleri:");

            for (int i = 0; i < erkekUrun.Length; i++)
            {
                if (urunler[i].urunIndirim == true)
                {
                    Console.WriteLine(erkekUrun[i].markaAdi + " " + erkekUrun[i].urunAdi + " Sadece " + erkekUrun[i].urunFiyat + " TL");
                }
            }

            Console.WriteLine("------------------------------------");

            Console.WriteLine("İndirimdeki Kadın Ürünleri:");

            for (int i = 0; i < kadinUrun.Length; i++)
            {
                if (urunler[i].urunIndirim == true)
                {
                    Console.WriteLine(kadinUrun[i].markaAdi + " " + kadinUrun[i].urunAdi + " Sadece " + kadinUrun[i].urunFiyat + " TL");
                }
            }

            Console.WriteLine("------------------------------------");

            Console.WriteLine("Tüm Ürünler:");


            foreach (var item in urunler)
            {
                Console.WriteLine(item.markaAdi + " " + item.urunAdi + " " + item.urunFiyat + " TL ");
            }
        }
    }
}
