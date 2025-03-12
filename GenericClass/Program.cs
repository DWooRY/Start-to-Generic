using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass
{
    class Program
    {
        static void Main(string[] args)
        {
            genericRepository<MusteriGeneric> repoMusteri = new genericRepository<MusteriGeneric>();
            List<MusteriGeneric> musterilerim = repoMusteri.Getir();
            repoMusteri.yeniKayitEKle(null);



            genericRepository<Urun> repoUrun = new genericRepository<Urun>();
            repoUrun.Getir();
            repoUrun.yeniKayitEKle(null);



        }
    }
}
