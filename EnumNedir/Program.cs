﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumNedir
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri M1 = new Musteri();
            M1.id = 1;
            M1.musteriNumara = "MSN001";
            M1.isim = "Enis";
            M1.soyisim = "Yildiz";
            M1.emailAdres = "eniscanyildiz@gmail.com";

            sanalDatabase SB = new sanalDatabase();
            musteriReturnValue musteriKayitSonuc = SB.musteriYeniKayit(M1);
        
            if (musteriKayitSonuc == musteriReturnValue.kayitBasarili)
            {

            }
        
        
        }
    }
}
