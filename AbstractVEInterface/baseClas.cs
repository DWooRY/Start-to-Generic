using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractVEInterface
{
    public abstract class baseClass
    {
        public DateTime kayitTarihi { get; set; }
        public DateTime guncellemeTarih { get; set; }

        public baseClass()
        {
            kayitTarihi = DateTime.Now;
            guncellemeTarih = DateTime.Now;
        }

        public void test()
        {
            Console.WriteLine("baseClass icerisindeki test");
        }

        public abstract void testAbstract(); //metot imzasi
        //{
        //}

    }
}
