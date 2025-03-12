using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalitimOdevUygulamasi
{
    public class urun : baseClass
    {
        public string marka { get; set; } // kontrol olacak belirli markalar olacak
        public string model { get; set; }

        private decimal _alisFiyat;
        public decimal alisFiyat
        {
            get { return _alisFiyat; }
            set
            {
                if (value > 0)
                {
                    _alisFiyat = value;
                }else Console.WriteLine("Alis fiyati 0 dan buyuk olmalidir.");
            }
        } // 0 dan büyük olacak
        private decimal _satisFiyat;
        public decimal satisFiyat
        {
            get { return _satisFiyat; }
            set
            {
                if (value >= _alisFiyat)
                {
                    _satisFiyat = value;
                }else Console.WriteLine("satis fiyati alis fiyatindan buyuk veye esit olmalidir.");
            }
        } // alis fiyatindan büyük olacak
        private decimal _kampanyaFiyat;
        public decimal kampanyaFiyat
        {
            get { return _kampanyaFiyat; }
            set
            {
                if (alisFiyat <= value && satisFiyat >= value)
                {
                    _kampanyaFiyat = value;
                }else Console.WriteLine("Kampanya fiyati alis ve satis fiyatinin arasinda bir deger olmalidir.");

            }
        } // 0dan büyük olacak





    }
}
