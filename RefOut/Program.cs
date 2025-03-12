using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefOut
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 0;
            degerAta(ref sayi1);
            //ref ve out anahtar kelimesi ile gönderilen değişkenin değeri değiştirilebilir.

            topla(5, 7, 11, 46, 25, 63, 16);
            //params anahtar kelimesi ile gönderilen değişken sayısı değişebilir. 
            //Gönderilen değişkenler bir diziye atanır.
            //Dizi üzerinde işlem yapılabilir.


        }

        static void degerAta(ref int x) // ref out
        {
            x = 10;
        }

        static void topla(params int[] sayilar) //Params
        {
            int toplam = 0;
            for (int i = 0; i < sayilar.Length; i++)
            {
                toplam += sayilar[i];
            }
            Console.WriteLine("Toplam: {0}", toplam);
        }

    }
}
