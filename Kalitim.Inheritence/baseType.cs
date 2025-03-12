using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim.Inheritence
{
    public class baseType
    {
        public int id { get; set; }
        public string referansKod { get; set; }
        public string tcKimlikNumarasi { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public int cinsiyet { get; set; }
        public DateTime kayitTarih { get; set; }
        public int kayitKullanici { get; set; }
        public DateTime guncellemeTarih { get; set; }
        public int guncellemeKullanici { get; set; }
        public bool silindi { get; set; }

        public baseType()
        {
            Console.WriteLine("baseType yapici metot.");
            idAtama();
        }

        private void idAtama()
        {
            Random rnd = new Random();
            id = rnd.Next(1111,9999);
        }

        public void baseTypeMethod1()
        {
            Console.WriteLine("baseTypeMethod1 metodu.");
        }

        protected void baseTypeMethod2()
        {
            Console.WriteLine("Protected metod.");
        }
    }
}
