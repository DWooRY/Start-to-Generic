﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractVEInterface
{
    class Musteri2 : Imusteri // bu class interface ornegi icin olusturuldu
    {
        int _id;
        string _isim;
        string _soyisim;
        public int Id { get { return _id; } set { _id = value; } }
        public string isim { get { return _isim; } set { _isim = value; } }
        public string soyisim { get { return _soyisim; } set { _soyisim = value; } }

        public int kayitDuzenle(int Id, string isim, string soyisim)
        {
            Console.WriteLine("Kayit duzenlendi");
            return 1;
        }

        public int kayitsil(int Id)
        {
            Console.WriteLine("Kayit silindi");
            return 1;
        }

        public int yeniKayit(string isim, string soyisim)
        {
            Console.WriteLine("Kayit eklendi");
            return 1;
        }
    }
}
