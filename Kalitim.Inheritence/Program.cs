using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim.Inheritence
{
    class Program
    {
        static void Main(string[] args)
        {
            Egitmen E1 = new Egitmen();
            E1.baseTypeMethod1();

            //Ozel tiplerde boxing ve unboxing

            //Object nesnemiz nedir? baseType.
            baseType B1;
            //Hangi nesnelerde baseType object gorevi gorur... Personel, Egitmen ve Ogrenci'de.
            //baseType nesnesinden turedikleri icin baseType nesnesi bu nesnelerde object gibi davranir.

            B1 = E1; // Egitmen nesnesini baseType nesnesine atadik. Boxing.
            E1 = (Egitmen)B1; // Unboxing

            Personel P1 = new Personel();
            B1 = P1; // Boxing
            P1 = (Personel)B1; // Unboxing

            Ogrenci O2 = new Ogrenci();
            B1 = O2; // Boxing
            O2 = (Ogrenci)B1; // Unboxing



            //object O1 = E1; // Boxing
            //E1 = (Egitmen)O1; // Unboxing

            //protected: Normal kullanimda private olarak davranir. Ancak kalitim yolu ile baska bir class iciresinde public olarak kullanilir.
            Ogrenci O3 = new Ogrenci();
            //O3.baseTypeMethod2 // Hata verir. Cunku protected metotlar sadece kalitim yolu ile cagirilabilir.



        }
    }
}
