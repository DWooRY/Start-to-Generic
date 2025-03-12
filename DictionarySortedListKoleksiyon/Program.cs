using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionarySortedListKoleksiyon
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<TKey,TValue> 

            Dictionary<int, string> DictionaryList = new Dictionary<int, string>();
            DictionaryList.Add(1, "Bir");
            DictionaryList.Add(2, "Iki");
            DictionaryList.Add(3, "Üç");

            bool silmeSonuc = DictionaryList.Remove(2);
            if (silmeSonuc)
            {
                Console.WriteLine("Silindi");
            }else Console.WriteLine("Aranan deger bulunamadi.");


            bool arananDegerSonuc = DictionaryList.ContainsKey(1);
            if (arananDegerSonuc)
            {
                string gelenDeger = DictionaryList[1];
                gelenDeger = "Yenilenen Deger";
                DictionaryList[1] = gelenDeger;

            } else Console.WriteLine("Aranan deger bulunamadi.");

            DictionaryList.ContainsValue("Bir"); // Value ile değer arar. Bool dönebilir.

            foreach (KeyValuePair<int,string> item in DictionaryList)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }

            DictionaryList.Clear(); // tum degerleri siler.

            //SortedList

            SortedList<int,string> sortedList = new SortedList<int,string>();

            sortedList.Add(100, "Yuz");
            sortedList.Add(50, "Elli");
            sortedList.Add(1, "Bir");
            sortedList.Add(1000, "Bin");






        }
    }
}
