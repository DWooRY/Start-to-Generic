using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerType
{
    class Musteri
    {
        #region Tekil olarak kullanilan field
        public int musteriID { get; set; }
        public string tcKimlikNo { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public DateTime olusturmaTarihi { get; set; }
        public int kullaniciID { get; set; }
        #endregion

        #region InnerType gerektiren fieldlar
        public MusteriAdres[] musteriAdresleri;
        public MusteriIletisimBilgisi[] musteriIletisimBilgileri;
        public MusteriSiparisBilgisi[] musteriSiparisBilgileri;
        public Urun[] urunler;
        #endregion

        public Musteri()
        {
            musteriAdresleri = new MusteriAdres[5];
            musteriIletisimBilgileri = new MusteriIletisimBilgisi[3];
            musteriSiparisBilgileri = new MusteriSiparisBilgisi[10];
            urunler = new Urun[20];
        }


    }
}
