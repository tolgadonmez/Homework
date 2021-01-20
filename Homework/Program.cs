using System;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Ad = "Tolga";
            musteri1.Soyad = "Donmez";
            musteri1.Id = 1818075;
            musteri1.Yas = 24;


            Musteri musteri2 = new Musteri();
            musteri2.Ad = "Eda";
            musteri2.Soyad = "Koken";
            musteri2.Id = 1515470;
            musteri2.Yas = 23;



            Musteri musteri3 = new Musteri();
            musteri3.Ad = "Cengizhan";
            musteri3.Soyad = "Bozkurt";
            musteri3.Id = 6767410;
            musteri3.Yas = 24;




            Musteri musteri4 = new Musteri();
            musteri4.Ad = "Alpay";
            musteri4.Soyad = "Ustalar";
            musteri4.Id = 0606250;
            musteri4.Yas = 25;


            Musteri[] musteriler = new Musteri[] {musteri1, musteri2, musteri3, musteri4 };

            foreach (Musteri x in musteriler)
            {
                Console.WriteLine("Musteri Ad: " + x.Ad );
                Console.WriteLine("Musteri Soyad: " + x.Soyad);
                Console.WriteLine("Musteri Id: " + x.Id);
                Console.WriteLine("Musteri Yas: " + x.Yas);
                Console.WriteLine("****************************************");
            }

           

        }
    }
}
