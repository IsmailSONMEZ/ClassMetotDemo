using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri();
            musteri.Id = 1;
            musteri.Ad = "İsmail";
            musteri.Soyad = "SÖNMEZ";
            musteri.Adres = "istanbul";

            Musteri musteri1 = new Musteri { Ad = "Gülden", Id = 2, Adres = "İstanbul", Soyad = "Sönmez" };

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri);
            musteriManager.Ekle(musteri1);
            Console.WriteLine("-----------------------------------");

            
            musteriManager.Sil(musteri);
            musteriManager.Sil(musteri1);
            Console.WriteLine("-----------------------------------");
        }
    }
}
