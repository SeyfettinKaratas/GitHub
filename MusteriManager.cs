using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle ( Musteri musteri )
        {
            Console.WriteLine("Musteri ekleme:" + Environment.NewLine+musteri.Id+ " " +musteri.Adi +" "+ musteri.Soyadi);
        }

        public void MusteriListele (Musteri[] musteriler)
        {
            Console.WriteLine("Musteri Listele:");
            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.Id+" "+musteri.Adi+" "+musteri.Soyadi);
                
            }
        }

        public void MusteriSil ( Musteri musteri )
        {
            Console.WriteLine("Musteri sil:" + Environment.NewLine + musteri.Id+ "  " + "  "+ musteri.Adi+ "  " + "  "+ musteri.Soyadi);
        }
    }
}
