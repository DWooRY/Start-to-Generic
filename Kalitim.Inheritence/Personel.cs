using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim.Inheritence
{
    public class Personel: baseType
    {
        public DateTime IsBaslangicTarihi { get; set; }
        public DateTime IsBitisTarihi { get; set; }
        public int IzinGunSayisi { get; set; }

        public Personel()
        {
            baseTypeMethod2(); // Protected metodu cagirdik. Protected metotlar sadece kalitim yolu ile cagirilabilir. 
        }

    }
}
