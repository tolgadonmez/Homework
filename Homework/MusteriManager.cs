using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    class MusteriManager
    {
        public void Ekleme(Musteri musteri)
        {
            Console.WriteLine("Musteri Eklenmistir. Müsteri Bilgileri: " + musteri.Ad + musteri.Soyad + musteri.Id + musteri.Yas);
        }

        public void Silme(Musteri musteri)
        {
            Console.WriteLine("Musteri Silinmistir. Müsteri Bilgileri: " + musteri.Ad + musteri.Soyad + musteri.Id + musteri.Yas);
        }

        public void Listeleme(Musteri musteri)
        {
            Console.WriteLine("Musteri Lİstelenmistir. Müsteri Bilgileri: " + musteri.Ad + musteri.Soyad + musteri.Id + musteri.Yas);
        }
    }
}
