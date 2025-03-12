using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass
{
    public partial class ogrenci
    {
        public int yeniKayit(ogrenci o)
        {
            Console.WriteLine("Kayit islemi basarili");
            return 1;
        }

        public int kayitGuncelle(ogrenci o)
        {
            Console.WriteLine("Guncelleme islemi basarili");
            return 1;
        }

        public int kayitSil(ogrenci o)
        {
            Console.WriteLine("Silme islemi basarili");
            return 1;
        }

}
}
