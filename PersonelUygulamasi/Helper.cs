using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelUygulamasi
{
    public static class Helper
    {

        static Helper() // Static CTOR-Constructor - Sınıf ilk kez kullanıldığında çalışır.
        {

        }

        public static void emailGonder(string aliciEmailAdres, string konu, string icerik)
        {
            // Mail gönderme işlemleri
            Console.WriteLine("Mail Gonderildi.");
        }
        


    }
}
