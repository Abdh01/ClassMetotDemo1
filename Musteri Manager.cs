using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetoDemo
{
    class Musteri_Manager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("Yeni musteri eklendi.Adi: "+musteri.Adi);
            Console.WriteLine("Yeni musterinin ID-si: "+musteri.MusteriID);
            Console.WriteLine("Yeni musterinin hesap numarasi: "+musteri.HesapNumarasi);
            Console.WriteLine("--------------------------------------------");
        }
    }
}
