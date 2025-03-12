using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumNedir
{
    public class sanalDatabase
    {
        ArrayList sanalDB = new ArrayList();

        public musteriReturnValue musteriYeniKayit(Musteri m)
        {
            sanalDB.Add(m);
            return musteriReturnValue.kayitBasarili;
        }

    }
}
