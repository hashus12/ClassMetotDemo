using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkleme(Musteri musteri)
        {
            Console.WriteLine(musteri+ " eklendi");
        }

        public void MusteriListeleme(Musteri musteri)
        {
            Console.WriteLine(musteri + " listelendi");

        }
        public void MusteriSilme(Musteri musteri)
        {
            Console.WriteLine(musteri + " silindi");

        }
    }
}
