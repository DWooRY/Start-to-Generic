using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Car
    {
        public string marka, model, yakitTipi, vitesTipi;
        public int modelYil, km;
        public double alisFiyat, satisFiyat, maxIndirimTutar, fiyat;

        public Car()
        {

        }
        public Car(string _marka, string _model)
        {
            marka = _marka;
            model = _model;
        }
        public Car(string _marka, string _model, int _modelYil)
        {
            marka = _marka;
            model = _model;
            modelYil = _modelYil;
        }
        public Car(string _marka, string _model, int _modelYil, int _km)
        {
            marka = _marka;
            model = _model;
            modelYil = _modelYil;
            km = _km;

        }

        public void BilgileriGoruntule()
        {
            Console.WriteLine("Marka: " + marka);
            Console.WriteLine("Model: " + model);
            Console.WriteLine("Model Yılı: " + modelYil);
            Console.WriteLine("Km: " + km);
            Console.WriteLine("Yakıt Tipi: " + yakitTipi);
            Console.WriteLine("Vites Tipi: " + vitesTipi);
            Console.WriteLine("Fiyat: " + fiyat);
        }

        public void FiyatAta(double _fiyat)
        {
            if (_fiyat <= satisFiyat - maxIndirimTutar)
            {
                fiyat = _fiyat;
                Console.WriteLine("Fiyat Guncellendi.");
            }
            else { Console.WriteLine("Atamak istediginiz fiyat maksimum indirim tutarindan fazla."); }

        }




    }
}
