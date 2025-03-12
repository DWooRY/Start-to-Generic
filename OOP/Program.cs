using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("bmw", "520I", 2025, 100);

            car.BilgileriGoruntule();
            car.FiyatAta(2499);

            car.BilgileriGoruntule();

            



        }
    }
}
