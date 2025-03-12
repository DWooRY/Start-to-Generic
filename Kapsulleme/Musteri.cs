using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kapsulleme
{
    internal class Musteri
    {
        public Musteri()
        {
            this.id = idUret();
        }


        //Class => Field
        public string isim;
        private string _soyisim;
        public string Soyisim
        {
            get
            {
                return _soyisim;
            }
            set
            {
                _soyisim = value;
                emailAdres = isim + "." + _soyisim + "@gmail.com";
            }
        }



        //Class => Property

        //hem okuma hem yazma
        string emailAdres;
        public string EmailAdres
        {
            get
            {
                return emailAdres;
            }
            set
            {
                emailAdres = value;
            }
        }


        //sadece okuma
        int id;
        public int ID
        {
            get
            {
                return id;
            }
            private set { }
        }

        //ara odev
        string tckimlikNo;
        public string TCKimlikNo
        {
            get
            {
                return tckimlikNo.Substring(0, 3);
            }
            set
            {
                if (value.Length == 11)
                {
                    bool kntrol = false;
                    for (int i = 0; i < value.Length; i++)
                    {
                        bool karakterKntrl = char.IsNumber(value[i]);
                        if (karakterKntrl == false)
                        {
                            kntrol = true;
                            break;
                        }
                    }
                    if (kntrol)
                    {
                        Console.WriteLine("Tc Kimlik Numarasi icindeki degerler sayisal olmalidir.");
                    }
                    else tckimlikNo = value;
                }
                else
                {
                    Console.WriteLine("Tc Kimlik Numarası 11 haneli olmalıdır.");
                }
            }
        }










        private int idUret()
        {
            Random rnd = new Random();
            return rnd.Next(1, 1000);
        }

    }
}
