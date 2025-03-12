using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelUygulamasi
{
    public class Personel
    {
        public static string domainAdresi;
        public string Isim { get; set; }
        public string SoyIsim { get; set; }


        private string _emailAdres;
        public string EmailAdres
        {
            get
            {
                return _emailAdres;
            }
            set
            {
                _emailAdres = value.ToLower() + "@" + domainAdresi;
            }
        }

        public int Cinsiyet { get; set; }


        public Personel()
        {
            Console.WriteLine("Her orneklemede calisir.");
        }

        static Personel()
        {
            domainAdresi = "firmam.com";
        }



    }
}
