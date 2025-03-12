using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanalMetot
{
    public class Musteri //: object // Bu satırı yazmasak da olur. Çünkü varsayılan olarak tüm sınıflar object sınıfından kalıtım alır.
    {
        public int musteriID { get; set; }
        public string isim { get; set; }
        public string soyIsim { get; set; }

        public override string ToString()
        {
            return isim + " " + soyIsim;
        }
    }
}
