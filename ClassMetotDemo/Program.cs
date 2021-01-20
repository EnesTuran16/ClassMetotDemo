using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.MusteriId = 1;
            musteri1.MusteriAd = "Enes";
            musteri1.MusteriSoyad = "Turan";

            Musteri musteri2 = new Musteri();
            musteri2.MusteriId = 2;
            musteri2.MusteriAd = "Engin";
            musteri2.MusteriSoyad = "Demiroğ";

            Musteri musteri3 = new Musteri();
            musteri3.MusteriId = 3;
            musteri3.MusteriAd = "Serdeha Mehmet";
            musteri3.MusteriSoyad = "Mutluay";


            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Ekle(musteri1);
            musteriManager.Listele(musteri2);
            musteriManager.Sil(musteri3);
        }
    }
}
