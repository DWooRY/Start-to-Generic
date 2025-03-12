using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelUygulamasi
{
    class Musteri
    {
        static ArrayList musteriListesi;
        static Musteri()
        {
            musteriListesi = new ArrayList();

        }
        public Musteri()
        {
        }

        private int id;
        public int Id { get { return id; } set { id = value; } }

        private string isim;
        public string Isim { get { return isim; } set { isim = value; } }

        private string soyIsim;
        public string SoyIsim { get { return soyIsim; } set { soyIsim = value; } }

        public string emailAdres;
        public string EmailAdres { get { return emailAdres; } set { emailAdres = value; } }

        private string kullaniciAdi;
        public string KullaniciAdi
        {
            get { return sifre; }
            set
            {
                if (kAdiKontrol(value))
                {
                    Console.WriteLine("Bu kullanici adi kullanilmaktadir.");
                    kullaniciAdi = string.Empty;
                }
                else
                {
                    kullaniciAdi = value;
                }
            }
        }

        private string sifre;
        public string Sifre { get { return sifre; } set { sifre = value; } }


        public static void musteriEkle(Musteri m)
        {
            if (m != null && !string.IsNullOrEmpty(m.kullaniciAdi) && !string.IsNullOrEmpty(m.emailAdres))
            {
                if (musteriEmailKontrol(m.emailAdres))
                {
                    Console.WriteLine("Bu email adresi kullanilmaktadir.");
                    
                }
                else
                {
                    musteriListesi.Add(m);
                }


            }
        }



        static bool kAdiKontrol(string kAdi)
        {
            bool Kontrol = false;

            for (int i = 0; i < musteriListesi.Count; i++)
            {
                Musteri Temp = (Musteri)musteriListesi[i];
                if (Temp.kullaniciAdi == kAdi)
                {
                    Kontrol = true;
                    break;
                }
            }

            return Kontrol;
        }

        static bool musteriEmailKontrol(string email)
        {
            bool Kontrol = false;
            for (int i = 0; i < musteriListesi.Count; i++)
            {
                Musteri Temp = (Musteri)musteriListesi[i];
                if (Temp.emailAdres == email)
                {
                    Kontrol = true;
                    break;
                }
            }
            return Kontrol;

        }



    }
}

