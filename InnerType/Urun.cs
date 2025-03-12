using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerType
{
    public class Urun
    {
        public string urunBilgisi { get; set; }

        public Urun() 
        {
            Console.WriteLine("Urun yapici metotu calisti.");
        }

        public void UrunTestMetot()
        {
            Console.WriteLine("UrunTestMetot");
        }

    }
}
