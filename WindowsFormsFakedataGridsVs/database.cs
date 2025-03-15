using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsFakedataGridsVs
{
    public class database
    {
        public List<musteri> musteriler = new List<musteri>();
        public database()
        {
            
        }

        public List<musteri> musteriListele()
        {
            for (int i = 1; i <= 1000; i++)
            {
                musteri temp = new musteri();
                temp.id = i;
                temp.isim = FakeData.NameData.GetFirstName();
                temp.soyisim = FakeData.NameData.GetSurname();
                temp.tamAdi = $"{temp.isim} {temp.soyisim}";
                temp.emailAdres = FakeData.NetworkData.GetEmail(temp.isim,temp.soyisim);
                temp.telefonNumara = FakeData.PhoneNumberData.GetPhoneNumber();
                temp.il = FakeData.PlaceData.GetCity();
                temp.ilce = FakeData.PlaceData.GetCountry();
                temp.adres = FakeData.PlaceData.GetAddress();
                musteriler.Add(temp);
            }
            return musteriler; 
        }

    }
}
