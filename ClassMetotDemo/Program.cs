using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();

            musteri1.Id = 1;
            musteri1.Ad = "Selma";
            musteri1.Soyad = "Aydın";

            Musteri musteri2 = new Musteri();

            musteri2.Id = 2;
            musteri2.Ad = "Sadık";
            musteri2.Soyad = "Turan";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

            MusteriManager musteriManager = new MusteriManager();

            Console.WriteLine("----MusteriEkleme----");
            musteriManager.MusteriEkleme(musteri1);

            Console.WriteLine("----MusteriListeleme----");
            musteriManager.MusteriListeleme(musteriler);

            Console.WriteLine("----MusteriSilme----");
            musteriManager.MusteriSilme(musteri1);
        }
    }
}
