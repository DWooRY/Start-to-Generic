using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            localFunctionKullanimi(11, 22);
        }

        static void localFunctionKullanimi(int sayi1, int sayi2)
        {
             int topla(int gSayi1, int gSayi2)
            {
                return gSayi1 + gSayi2;
            }

            int toplmDeger = topla(sayi1, sayi2);
            Console.WriteLine("Toplam Değer: " + toplmDeger);
        }
    }
}
