using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace KalitimOdevUygulamasi
{
    public class sanalDatabase
    {
        private static ArrayList db = new ArrayList();

        public static void yeniUrunEKle(baseClass data)
        {
            if (data != null && !string.IsNullOrEmpty(data.barkod))
            {
                db.Add(data);
            }
        }

        public static bool barkodKontrol(string barkod)
        {
            bool kontrol = false;
            for (int i = 0; i < db.Count; i++)
            {
                baseClass temp = (baseClass)db[i];
                if (barkod == temp.barkod)
                {
                    kontrol = true; break;
                }
            }
            return kontrol;
        }

    }
}
