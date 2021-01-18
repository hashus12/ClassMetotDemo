using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkleme(Musteri musteri)
        {
            Console.WriteLine("Musteri Id : " + musteri.Id);
            Console.WriteLine("Musteri Adi : " + musteri.Ad);
            Console.WriteLine("Muster Soyadi : " + musteri.Soyad);
        }

        public void MusteriListeleme(Musteri[] musteriler)
        {
            foreach (var musteri in musteriler)
            {
                Console.WriteLine("Musteri Id : " + musteri.Id);
                Console.WriteLine("Musteri Adi : " + musteri.Ad);
                Console.WriteLine("Muster Soyadi : " + musteri.Soyad);
            }
           

        }
        public void MusteriSilme(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " silindi");

        }
    }
}
