using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
           

            Musteri musteri1 = new Musteri();
            musteri1.Id = 12345;
            musteri1.Adi = "Seyfettin";
            musteri1.Soyadi = "Karatas";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 23456;
            musteri2.Adi = "Burhan";
            musteri2.Soyadi = "Savci";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };
           


            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriEkle(musteri2);



            MusteriManager musteriManager1 = new MusteriManager();
            musteriManager1.MusteriListele(musteriler);
          



            MusteriManager musteriManager2 = new MusteriManager();
            musteriManager2.MusteriSil(musteri1);
            musteriManager2.MusteriSil(musteri2);




        }
    }
}
