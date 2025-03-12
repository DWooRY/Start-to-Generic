using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim.Inheritence
{
    public sealed class Egitmen: Personel
    {
        public string Brans { get; set; }
        public int Seviye { get; set; }

        public Egitmen()
        {
            Console.WriteLine("Egitmen nesnesinin yapici metotu.");
        }
    }
}
