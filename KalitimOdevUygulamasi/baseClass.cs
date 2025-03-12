using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace KalitimOdevUygulamasi
{
    public class baseClass: sanalDatabase
    {
        public static int sayac = 1;

        private int _id;
        public int id
        {
            get { return _id; }
            private set
            {


            }
        } // kontrol olacak

        private string _barkod;
        public string barkod
        {
            get { return _barkod; }
            set
            {
                bool dbKontrol = sanalDatabase.barkodKontrol(value);
                if (!dbKontrol)
                {
                    _barkod = value;
                } else Console.WriteLine("Sanal database icerisinde bu barkod var.");
            } // kontrol olacak
        }


        public DateTime olusturmaTarih { get; set; }
        public int olusturanKullanici { get; set; }

        public DateTime guncellemeTarih { get; set; }
        public int guncelleyenKullanici { get; set; }

        public bool silindi { get; set; }

        public baseClass()
        {
            _id = sayac;
            sayac++;   
        }

    }
}
