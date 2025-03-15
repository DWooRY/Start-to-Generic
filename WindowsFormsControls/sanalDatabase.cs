using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsControls
{
    public static class sanalDatabase
    {
        public static List<Musteriler> Musterilers { get; set; }

        static sanalDatabase()
        {
            Musterilers = new List<Musteriler>();
        }

    }
}
