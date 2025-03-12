using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractVEInterface
{
    public interface Imusteri
    {
        //Interface icinde yapici metot (ctor) kullanilamaz.

        //interface icinde neler olur
        /* field
         * metot
         * delegate
         * vb...
         */

        int Id { get; set; }
        string isim { get; set; }
        string soyisim { get; set; }

        //olusturulabilecek metot tarzi
        int yeniKayit(string isim, string soyisim);
        int kayitDuzenle(int Id, string isim, string soyisim);
        int kayitsil(int Id);








    }
}
