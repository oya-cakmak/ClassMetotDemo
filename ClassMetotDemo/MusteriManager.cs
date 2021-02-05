using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri[] musteriler)
        {
            foreach (Musteri musteri in musteriler)
            {

                Console.WriteLine(musteri.MusteriAd + " " + musteri.MusteriSoyad + " eklendi");
            }
        }

        public void Listele(Musteri[] musteriler)
        {
            foreach (Musteri musteri in musteriler)
            {

                Console.WriteLine(musteri.Id + " " + musteri.Tc + " " + musteri.MusteriAd + " " +
                    musteri.MusteriSoyad + " " + musteri.Bakiye + " " + musteri.HesapTuru);
            }
        }

        public void Sil(Musteri[] musteriler)
        {
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.MusteriAd + " " + musteri.MusteriSoyad + " silindi");
            }
        }
    }
}
