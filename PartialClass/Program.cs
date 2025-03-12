using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass
{
    class Program
    {
        static void Main(string[] args)
        {
            musteri m1 = new musteri();

            m1.id = 1;
            m1.isim = "Enis";
            m1.soyisim = "Yildiz";
            m1.emailAdres = "eniscanyildiz@gmail.com";

            int sonuc = m1.yeniKayit(m1);
            if (sonuc > 0)
            {
                Console.WriteLine("Database yeni kayit eklendi");
            }

            ogrenci O1 = new ogrenci();
            O1.id = 1;
            O1.yeniKayit(O1);

            


        }
    }
}
