using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalitimOdevUygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            bilgisayar B1 = new bilgisayar();
            B1.marka = "Asus";
            B1.model = "X550V";
            B1.islemci = "Intel i7";
            B1.alisFiyat = 3000;
            B1.satisFiyat = 4000;
            B1.kampanyaFiyat = 3500;
            B1.barkod = "123456";

            sanalDatabase.yeniUrunEKle(B1);

            bilgisayar B2 = new bilgisayar();
            B2.marka = "Asus1";
            B2.model = "X550V2";
            B2.islemci = "Intel4 i7";
            B2.alisFiyat = 3000;
            B2.satisFiyat = 4000;
            B2.kampanyaFiyat = 3500;
            B2.barkod = "1234567";

            sanalDatabase.yeniUrunEKle(B2);

            bilgisayar B3 = new bilgisayar();
            B3.marka = "Asus2";
            B3.model = "X550V1";
            B3.islemci = "Intel3 i7";
            B3.alisFiyat = 3000;
            B3.satisFiyat = 4000;
            B3.kampanyaFiyat = 3500;
            B3.barkod = "1234567";

            sanalDatabase.yeniUrunEKle(B3);



        }
    }
}
