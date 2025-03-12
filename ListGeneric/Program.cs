using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            // Arraylistin generic versiyonu

            //Arraylist
            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add("bir");

            //ListGeneric
            // <T> : T tipi demek .net framework icerisinde olan veya
            //  bizim olusturdugumuz herhangi bir tip.
            // Generic liste'de bizim belirledigimiz bir tipde ( int, string)
            //  atama yapabiliriz. ArrayList'te ise object ile (kisaca herseyle)
            //  Generic liste'nin temel aciklamasi budur. Tip korumalidir.

            List<int> listGeneric = new List<int>();
            listGeneric.Add(1);
            listGeneric.Add(2);
            //listGeneric.Add("Üç"); hata verir yapamayiz!

            for (int i = 0; i < listGeneric.Count; i++)
            {
                Console.WriteLine(listGeneric[i]);
            }

            List<string> isimler = new List<string>();
            isimler.Add("Enis");
            isimler.Add("Sevda");
            //isimler.Add(1524); tip güvenli! string dışında tip alamaz!

            for (int i = 0; i < isimler.Count; i++)
            {
                Console.WriteLine(isimler[i]);
            }


            List<musteri> musteriListe = new List<musteri>();
            musteriListe.Add(new musteri()
            {
                id = 1,
                isim = "Enis",
                soyisim = "Yildiz"
            });

            foreach (musteri item in musteriListe)
            {
                Console.WriteLine(item.isim);
            }





        }
    }
}
