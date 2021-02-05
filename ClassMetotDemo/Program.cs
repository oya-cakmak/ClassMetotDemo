using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri
            {
                Id = 1,
                Tc = "1111111",
                MusteriAd = "Aaaa",
                MusteriSoyad = "Bbbb",
                Bakiye = 50000,
                HesapTuru = "Vadeli Hesap",

            };

            Musteri musteri2 = new Musteri
            {
                Id = 2,
                Tc = "1234121",
                MusteriAd = "Cccc",
                MusteriSoyad = "Dddd",
                Bakiye = 18000,
                HesapTuru = "Vadeli Hesap",
            };
            Musteri musteri3 = new Musteri
            {
                Id = 3,
                Tc = "1299990",
                MusteriAd = "Aaa",
                MusteriSoyad = "Bbb",
                Bakiye = 20000,
                HesapTuru = "Vadeli Hesap",
            };

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Ekle(new Musteri[] { musteri1, musteri2, musteri3 });

            Console.WriteLine("~~~~~~~~~~~");

            musteriManager.Listele(new Musteri[] { musteri1, musteri2, musteri3 });

            Console.WriteLine("~~~~~~~~~~~");

            musteriManager.Sil(new Musteri[] { musteri2, musteri3 });

            Console.ReadLine();
        }
    }
}
