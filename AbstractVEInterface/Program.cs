﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractVEInterface
{
    class Program
    {
        static void Main(string[] args)
        {

            //Abstract

            superMusteri SP1 = new superMusteri();
            SP1.testAbstract();


            musteri M1 = new musteri();
            M1.test();
            M1.testAbstract();


            //Interface 









        }
    }
}
