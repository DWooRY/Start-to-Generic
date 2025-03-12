using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractVEInterface
{
    public class musteri : baseClass // bu class abstract ornegi icin olusturuldu
    {
        public int musteriID { get; set; }

        public musteri()
        {
            musteriID = 1;
        }

        public override void testAbstract()
        {
            Console.WriteLine("musteri => testAbstract");
        }
    }
}
