using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass
{
    public class genericRepository<T> where T : class
    {
        public genericRepository()
        {
            // context : EF DBFirst
        }

        public virtual List<T> Getir()
        {
            //Gelen T tipini database uzerinden sorgulamak ve elde etmis
            //  oldugumuz kayitlari generic koleksiyon olarak bir ust katmana
            //  donmek...
            return null;
        }

        public virtual void yeniKayitEKle(T data)
        {
            //Bize gelen T tipi icerisindeki bilgiyi T tipinin isaret etmis
            // oldugu tabloya ekliyoruz...
        }
    }
}
