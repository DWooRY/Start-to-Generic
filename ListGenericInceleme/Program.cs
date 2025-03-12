using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListGenericInceleme
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sayilarim = new List<int>();

            sayilarim.Add(1);


            // bir diziyi/çoklu datayı listgeneric'e toplu ekleme.
            int[] eklenecekData1 = new int[4];
            eklenecekData1[0] = 2;
            eklenecekData1[1] = 3;
            eklenecekData1[2] = 4;
            eklenecekData1[3] = 5;

            sayilarim.AddRange(eklenecekData1);

            // kapasite - sayi
            int capacity = sayilarim.Capacity; // capacity = 8
            int count = sayilarim.Count; // count = 5

            sayilarim.TrimExcess(); // count = 5, capacity = 5

            //ek bir foreach veya for dongusu yerine ListGeneric'te boyle bir foreach kullanim metotumuz var.
            sayilarim.ForEach(i => Console.WriteLine(i));
            // (=>) bu isaretin anlami = ilgili koleksiyon icerisinde arama yap (linq konusu)

            int bulunanDeger = sayilarim[3];
            Console.WriteLine("List<T> icindeki 3. indexte bulunan deger {0}",bulunanDeger);

            sayilarim.Insert(3, 100); // 3. indexe belirtmis oldugum degeri atadi. var olan degeri 1 alta kaydirdi.

            bool kontrol1 = sayilarim.Any(); // koleksiyon icerisinde herhangi bir deger var ise true deger dondurur.
            bool kontrol2 = sayilarim.Any(i => i > 5); // koleksiyon icerisinde 5 degeri var ise true deger donduruyor.

            sayilarim.Sort(); // A-Z veya 1-N siralama gerceklestirir.
            sayilarim.Reverse(); // siralamayi ters cevirir.

            int enYuksekDeger = sayilarim.Max(); //Listedeki en yuksek degeri verir.
            int enDusukDeger = sayilarim.Min(); //Listedeki en dusuk degeri verir.
            int toplamDeger = sayilarim.Sum(); //Listedeki tum sayilari toplar.
            int aralikliToplam = sayilarim.Sum(i => 15); //Listedeki 15 ve uzeri degerde olan sayilari toplar.





            bool silmeIslemiSonuc = sayilarim.Remove(100); //Girilen degeri listeden siler. Geriye bool deger dondurebilir.
            sayilarim.RemoveAll(i => i > 5); // 5den buyuk tum degerleri siler.
            sayilarim.RemoveAt(1); // 1. indexteki degeri siler. Indexe gore silme islemi yapar.


            sayilarim.Clear(); // koleksiyondaki tum degerleri siler.









        }
    }
}
