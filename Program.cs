using System;

namespace ClassMetoDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.MusteriID = "id19864535";
            musteri1.Adi = "Hakan";
            musteri1.HesapNumarasi = 34765982;

            Musteri musteri2 = new Musteri();
            musteri2.MusteriID = "id34900012";
            musteri2.Adi = "Kemal";
            musteri2.HesapNumarasi = 45998065;
            Musteri musteri3 = new Musteri();
            musteri3.MusteriID = "id12345678";
            musteri3.Adi = "Ozcan";
            musteri3.HesapNumarasi = 78643211;
            Musteri[] musteriler = new Musteri[] {musteri1,musteri2, };
            foreach (var musteri in musteriler)
            {
                Console.WriteLine("musteri ID-si: "+musteri.MusteriID);
                Console.WriteLine("Musteri adi: "+musteri.Adi);
                Console.WriteLine("Musteri1`nin hesapno: "+musteri.HesapNumarasi);
                Console.WriteLine("------------------------");
             }
            Console.WriteLine("------------Metotlar-------------");
            Musteri_Manager musteriManager = new Musteri_Manager();
            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriEkle(musteri2);
            musteriManager.MusteriEkle(musteri3);


        }
    }
}
