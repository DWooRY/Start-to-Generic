using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    public class Ogrenci
    {
        public string Isim { get; set; }
        public string SoyIsim { get; set; }
        public string EmailAdres { get; set; }


        public void Test1()
        {
            Console.WriteLine("Nesne ornegi alindiktan sonra calisan metot.");
            // static olmayan bir metot static olan bir metotu cagirabilir. Orn: Test2();
        }

        public static void Test2()
        {
            Console.WriteLine("Nesne ornegi ALINMADAN kullanilabilir.");
            // static olan bir metot static olmayan bir metodu vb. cagiramaz. Orn: Test1();
        }




    }
}
