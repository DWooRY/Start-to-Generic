using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    class Program
    {
        static void Main(string[] args)
        {
            // Static class'lar new'lenemezler. static class'lar sadece static metotlar ve field'lar içerebilirler. 

            // stack bolge icerisinde pointer'imiz olustu.
            Ogrenci O1;
            // pointer olustugu zaman static olan bir yapici metot calisti ve yine class icerisinde tanimli olan static field, metot static dedigimiz bolgede olusturuldu.
            Ogrenci.Test2(); // Nesne ornegi alinmadan Test2 metotuna ulasabildim.

            O1 = new Ogrenci();
            // Stack bolgede pointer => kendisini heap bolgede tamamladi. static olmayan tanimlarini tamamladi.
            O1.Test1(); // Nesne ornegi alindiktan sonra Test1 metotuna ulasabildim.






        }
    }
}
