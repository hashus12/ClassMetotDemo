using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();

            musteri1.Id = 1;
            musteri1.Ad = "Hasan";
            musteri1.Soyad = "Özgen";

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.MusteriEkleme(musteri1);
            musteriManager.MusteriListeleme(musteri1);
            musteriManager.MusteriSilme(musteri1);
        }
    }
}
