using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotveOOP
{
    public class Ogrenci
    {
        //public void ogrenciSelamla()
        //{
        //    Console.WriteLine("Merhaba, öğrenci.");
        //}

        /*
         * [Erisim Belirleyicileri] <DonusTipi> <MetotAdi> (<ParametreListesi>)
         * {
         *      //Metot icin gereken kodlar
         * }
         * Erisim belirleyicileri
         * 
         * Public: Herkes tarafından erişilebilir.
         * Private: Sadece tanımlandığı sınıf içerisinde erişilebilir.
         * Protected: Tanımlandığı sınıf ve bu sınıftan türetilen sınıflar tarafından erişilebilir.
         * Internal: Tanımlandığı proje içerisinde erişilebilir.
         * Internal Protected: Tanımlandığı proje içerisinde ve bu sınıftan türetilen sınıflar tarafından erişilebilir.
         */

        //public void OgrenciMetot1(string ogrenciAdi, string ogrenciSoyadi)
        //{
        //    Console.WriteLine("Ogrenci Bilgileri: {0} {1}", ogrenciAdi, ogrenciSoyadi);
        //}

        public void OgrenciBilgi()
        {
            Console.Write("Adiniz: ");
            string ogrAd = Console.ReadLine();
            Console.Write("Soyadiniz: ");
            string ogrSoyad = Console.ReadLine();
            Console.Write("1. Notunuz: ");
            int not1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. Notunuz: ");
            int not2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("3. Notunuz: ");
            int not3 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            double ort = OrtalamaHesapla(not1, not2, not3);
            Console.WriteLine("Sevgili {0} {1}  \n Not Ortalamaniz: {2}",ogrAd,ogrSoyad,ort);


        }


        private double OrtalamaHesapla(int not1, int not2, int not3)
        {
            return (not1 + not2 + not3) / 3;
        }



    }

}
