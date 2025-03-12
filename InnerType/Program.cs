using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerType
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri M1 = new Musteri();
            M1.musteriID = 1;
            M1.tcKimlikNo = "12345678901";
            M1.isim = "Ali";
            M1.soyisim = "Veli";
            M1.olusturmaTarihi = DateTime.Now;

            M1.musteriAdresleri[0] = new MusteriAdres()
            {
                Il = "Istanbul",
                Ilce = "Kadikoy",
                Adres = "Kadikoy Sahil",
                adresTip = "717770001"
            };

            M1.urunler[0] = new Urun()
            {
                urunBilgisi = "Urun Bilgisi",
            };


            M1.musteriAdresleri[0].MusteriAdresTestMetot();
        }
    }
}
