using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kapsulleme
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri M1 = new Musteri();
            M1.isim = "Enis";
            M1.Soyisim = "Yildiz";

            M1.EmailAdres = "eniscanyildiz@gmail.com";

            M1.TCKimlikNo = "16982337188";
            string TC = M1.TCKimlikNo;



        }
    }
}
