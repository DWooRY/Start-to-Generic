using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelUygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            //Musteri Uygulamasi Class ve buradan ibarettir.

            Musteri M1 = new Musteri();
            M1.Id = 1;
            M1.Isim = "Enis";
            M1.SoyIsim = "Yildiz";
            M1.EmailAdres = "enis.yildiz@hotmail.com";
            M1.KullaniciAdi = "DWooRY";
            M1.Sifre = "123456";

            Musteri.musteriEkle(M1);

            Musteri M2 = new Musteri()
            {
                Id = 2,
                Isim = "Sudenaz",
                SoyIsim = "Yildiz",
                EmailAdres = "Sudenazyildiz@gmail.com",
                KullaniciAdi = "DWDW",
                Sifre = "123456"
            };

            Musteri.musteriEkle(M2);

            //




            Personel P1 = new Personel();
            P1.Isim = "Enis";
            P1.SoyIsim = "Yildiz";
            P1.EmailAdres = "enis.yildiz";
            P1.Cinsiyet = 717770001; // Erkek - 717770002 : Kadın

            Helper.emailGonder("ik@firmam.com", "Yeni Personel", P1.Isim + " " + P1.SoyIsim);


        }
    }
}
