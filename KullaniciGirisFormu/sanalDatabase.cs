using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KullaniciGirisFormu
{
    public class sanalDatabase
    {
        public static List<kullanici> kullaniciTablo = new List<kullanici>();

        static sanalDatabase()
        {
            kullaniciTablo.Add(new kullanici()
            {
                id = 1,
                isim = "enis",
                soyIsim = "yildiz",
                kullaniciAdi = "enis.yildiz",
                sifre = "1",
                aciklama = "admin"
            });

            kullaniciTablo.Add(new kullanici()
            {
                id = 2,
                isim = "sevda",
                soyIsim = "yildiz",
                kullaniciAdi = "sevda.yildiz",
                sifre = "1",
                aciklama = "kullanici"
            });

            kullaniciTablo.Add(new kullanici()
            {
                id = 3,
                isim = "fatma",
                soyIsim = "yildiz",
                kullaniciAdi = "fatma.yildiz",
                sifre = "1",
                aciklama = "kullanici"
            });
        }


    }
}
