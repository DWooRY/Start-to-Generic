using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass
{
    public class musteri
    {
        public int id { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public string emailAdres { get; set; }


        public int yeniKayit(musteri m)
        {
            Console.WriteLine("database kayit islemleri tamamlandi");
            return 1;
        }

        public int kayitGuncelle(musteri m)
        {
            Console.WriteLine("database kayit guncelleme islemleri tamamlandi");
            return 1;
        }

        public int kayitSil(musteri m)
        {
            Console.WriteLine("database kayit silme islemleri tamamlandi");
            return 1;
        }


    }
}
