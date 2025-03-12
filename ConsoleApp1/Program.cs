using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //string deneme = "";
            //Console.Write(" Aynı Satırdayım bak.");
            //Console.WriteLine("Hello World");
            //Console.WriteLine("Tekrardan başladık He!");
            //Console.Write("Şimdi bana bir yazı yaz: ");
            //deneme = Console.ReadLine();
            //Console.WriteLine("Deneme: " + deneme);

            //Console.WriteLine("Bir sayı gir: ");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //-------------------------------------------------------


            //bool kontrol;
            //Console.WriteLine("1 veya 2 gir: ");
            //int kontrolSayisi = Convert.ToInt32(Console.ReadLine());

            //if (kontrolSayisi == 1)
            //{
            //    kontrol = true;
            //    Console.WriteLine("Evet");
            //}
            //else if (sayi == 2)
            //{
            //    kontrol = false;
            //    Console.WriteLine("Hayır");
            //}
            //else
            //{
            //    Console.WriteLine("1 veya 2 girmelisin.");

            //}
            //-------------------------------------------------------

            //Console.Write("First Number: ");
            //decimal firstNumber = Convert.ToDecimal(Console.ReadLine());
            //Console.Write("Second Number: ");
            //decimal secondNumber = Convert.ToDecimal(Console.ReadLine());

            //Console.Clear();

            //Console.WriteLine("Toplam: " + (firstNumber + secondNumber));
            //Console.WriteLine("Cikarma: " + (firstNumber - secondNumber));
            //Console.WriteLine("Carpma: " + (firstNumber * secondNumber));
            //Console.WriteLine("Bolme: " + (firstNumber / secondNumber));
            //Console.WriteLine("Mod: " + (firstNumber % secondNumber));

            //Console.ReadLine();

            //-------------------------------------------------------
            //Console.Write("Kullanıcı adınızı giriniz: ");
            //string kAdi = Console.ReadLine();
            //kAdi = kAdi.ToUpper();

            //if (kAdi == "ABC" || kAdi == "123" || kAdi == "236" || kAdi == "CMK")
            //{
            //    Console.WriteLine("Kullanıcı girişiniz başarılı. ");
            //}
            //else if(kAdi == "HHH" || kAdi == "BBB" || kAdi == "MMM")
            //{
            //    Console.WriteLine("Kullanıcı girişiniz Kısıtlanmıştır. ");
            //}
            //else
            //{
            //    Console.WriteLine("Kullanıcı kodunuz hatalı. ");
            //}

            //-------------------------------------------------------
            //Console.WriteLine("Hangi işlemi yapmak istiyorsunuz? \n 1-) Toplama \n 2-) Çıkarma \n 3-) Çarpma \n 4-) Bölme ");
            //Console.Write("Seçiminiz: ");
            //string secim = Console.ReadLine();

            //Console.Write("Bir sayı giriniz: ");
            //double sayi1 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("İkinci sayıyı giriniz: ");
            //double sayi2 = Convert.ToInt32(Console.ReadLine());

            //if (secim == "1")
            //{
            //    Console.WriteLine("Girdiğiniz sayıların toplamı: " + (sayi1 + sayi2));
            //}
            //else if (secim == "2")
            //{
            //    Console.WriteLine("Girdiğiniz sayıların Çıkarması: " + (sayi1 - sayi2));
            //}
            //else if (secim == "3")
            //{
            //    Console.WriteLine("Girdiğiniz sayıların Çarpımı: " + (sayi1 * sayi2));
            //}
            //else if (secim == "4")
            //{
            //    if (sayi2 != 0)
            //    {
            //        Console.WriteLine("Girdiğiniz sayıların Bölmesi: " + (sayi1 / sayi2));
            //    }
            //    else
            //    {
            //        Console.WriteLine("Bölen değer 0 olamaz. ");
            //    }

            //}
            //else
            //{
            //    Console.WriteLine("Yanlış bir işlem seçtiniz. ");
            //}

            //-------------------------------------------------------

            //string adSoyad;
            //double not1, not2, not3, ortalama;
            //Console.WriteLine("Not Ortalamasi sistemine hos geldiniz. ");

            //Console.Write("Adinizi ve soyadinizi giriniz: ");
            //adSoyad = Console.ReadLine();

            //Console.Write("1. Notunuzu giriniz: ");
            //not1 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("2. Notunuzu giriniz: ");
            //not2 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("3. Notunuzu giriniz: ");
            //not3 = Convert.ToDouble(Console.ReadLine());

            //ortalama = (not1 + not2 + not3) / 3;

            //Console.Clear();
            //if (ortalama >= 0 && ortalama < 45)
            //{
            //    Console.WriteLine(adSoyad + " ortalamaniz " + ortalama + " kaldiniz.");
            //}
            //else if (ortalama >= 45 && ortalama < 85)
            //{
            //    Console.WriteLine(adSoyad + " ortalamaniz " + ortalama + " gectiniz.");
            //}
            //else if (ortalama >= 85 && ortalama <= 100)
            //{
            //    Console.WriteLine(adSoyad + " ortalamaniz " + ortalama + " yuksek puanla gectiniz, tebrikler.");
            //}
            //else
            //{
            //    Console.WriteLine(adSoyad + " notlarinizi kontrol ediniz.");
            //}

            //-------------------------------------------------------

            //Console.Write("Kullanici Kodunuz: ");
            //string kAdi = Console.ReadLine().ToUpper();

            //switch (kAdi)
            //{
            //    case "AA":
            //    case "BB":
            //    case "CC":
            //        Console.WriteLine("Admin girisi yapildi. ");
            //        break;

            //    case "DD":
            //        Console.WriteLine("Yetkili girisi yapildi. ");
            //        break;

            //    case "EE":
            //    case "FF":
            //    case "GG":
            //        Console.WriteLine("Kullanici girisi yapildi. ");
            //        break;

            //    default: Console.WriteLine("Kullanici kodu gecersiz. ");
            //        break;
            //}


            //-------------------------------------------------------

            //int ciftToplam = 0;
            //for (int i = 0; i <= 1000; i+=2)
            //{
            //    ciftToplam += i;
            //}
            //Console.WriteLine("1 ile 100 arasindaki cift sayilarin toplami: "+ciftToplam);

            //-------------------------------------------------------

            //Console.Write("Faktoriyelini almak istediginiz sayiyi girin: ");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //double faktoriyel = 1;

            //for (int i = sayi; i > 1; i--)
            //{
            //    faktoriyel *= i;
            //}
            //Console.WriteLine("Sayinin faktoriyeli: "+faktoriyel);

            //Console.ReadLine();

            //-------------------------------------------------------

            //for (int i = 1; i <= 10; i++)
            //{
            //    for (int x = 1; x <= 10; x++)
            //    {
            //        Console.Write("{0}*{1}={2}\t",i,x,(i*x));
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadLine();


            //-------------------------------------------------------

            //int rast = new Random().Next(1, 10);
            //Console.WriteLine("1 ile 10 arasinda bir sayi tuttum! Tahmin edebilir misin?");
            //while (true)
            //{
            //    Console.Write("Tahmin: ");
            //    int tahmin = Convert.ToInt32(Console.ReadLine());
            //    if (tahmin == rast)
            //    {
            //        Console.WriteLine("Tebrikler! Dogru tahmin ettiniz.");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Yanlis tahmin ettiniz. Tekrar deneyin.");
            //    }
            //}

            //-------------------------------------------------------

            //string kAdi, sifre;
            //do
            //{
            //    Console.Clear();
            //    Console.Write("Kullanici Adi: ");
            //    kAdi = Console.ReadLine();
            //    Console.Write("Sifre: ");
            //    sifre = Console.ReadLine();

            //} while (kAdi != "Demo" && sifre != "Demo");

            //Console.WriteLine("Giris Basarili. \n\n Press Enter to continue.");
            //Console.ReadLine();
            //Console.Clear();

            //int sayi1, sayi2, tahmin,sayac = 0;

            //Console.WriteLine("Iki deger arasinda sayi tahmin etme oyununa hosgeldiniz. ");
            //Console.Write("Birinci Sayiyi Girin: ");
            //sayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Ikinci Sayiyi Girin: ");
            //sayi2 = Convert.ToInt32(Console.ReadLine());

            //int rast = new Random().Next(sayi1, sayi2);
            //Console.WriteLine("Tahmin etmek icin {0} ile {1} arasinda bir sayi tuttum. ", sayi1, sayi2);

            //do
            //{
            //    Console.Write("Sayiyi Tahmin edin: ");
            //    tahmin = Convert.ToInt32(Console.ReadLine());
            //    sayac++;
            //} while (tahmin != rast);

            //Console.WriteLine("Tebrikler {0}. Tahminde dogru bildiniz",sayac);

            //-------------------------------------------------------

            //Console.Write("Kac elemanli bir dizi istiyorsunuz: ");
            //int elemanSayisi = Convert.ToInt32(Console.ReadLine());

            //int[] eDizi = new int[elemanSayisi];
            //double toplam = 0, ortalama = 0;

            //for (int i = 0; i < eDizi.Length; i++)
            //{
            //    Console.Write("{0}. Sayiyi girin: ", i + 1);
            //    eDizi[i] = Convert.ToInt32(Console.ReadLine());
            //    toplam += eDizi[i];
            //}

            //ortalama = toplam / eDizi.Length;

            //Console.WriteLine("Girdiginiz sayilarin toplami: " + toplam);
            //Console.WriteLine("Girdiginiz sayilarin ortalamasi: " + ortalama);

            //-------------------------------------------------------

            //int[] rndDizi = new int[20];
            //Random rnd = new Random();

            //for (int i = 0; i < rndDizi.Length; i++)
            //{
            //    rndDizi[i] = rnd.Next(1, 10);
            //}

            //int sayac = 0;
            //Console.WriteLine("Dizi icerisindeki degerler: ");
            //foreach (var item in rndDizi)
            //{
            //    Console.Write(item +" / ");
            //    if (item == 4)
            //    {
            //        sayac++;
            //    }
            //}
            //Console.WriteLine("");
            //Console.WriteLine("Dizi icerisinde {0} adet 4 bulunuyor.",sayac);
            //Console.ReadLine();

            //-------------------------------------------------------
            /*
            ArrayList A1 = new ArrayList(); //ArrayList tanimlama
            A1.AddRange(new string[] {"k","b","d","c","e","f","i","h","g","a"}); //ArrayList'e coklu eleman ekleme
            A1.Sort(); // A'dan Z'ye siralar
            A1.Reverse(); // Ters cevirir
            A1.Contains("a"); // Icerisinde a var mi kontrol eder
            A1.Remove("a"); // a elemanini siler
            A1.RemoveAt(0); // 0. indexdeki elemani siler
            A1.Clear(); // ArrayList'i temizler
            A1.Add("z"); // ArrayList'e eleman ekler
            A1.Insert(0, "a"); // 0. indexe a elemanini ekler
            A1.IndexOf("a"); // a elemaninin indexini arar
            A1.Count; // ArrayList'in eleman sayisini verir
            A1.Capacity; // ArrayList'in kapasitesini verir
            A1.TrimToSize(); // ArrayList'in kapasitesini eleman sayisina esitler
            A1.ToArray(); // ArrayList'i diziye cevirir
            */

            //-------------------------------------------------------
            /* Arraylist
             
            string secim = "";
            ArrayList degerListesi = new ArrayList();
            do
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1-) Deger Ekle");
                Console.WriteLine("2-) Deger Listele");
                Console.WriteLine("3-) Deger Ara");
                Console.WriteLine("4-) Deger Guncelle");
                Console.WriteLine("5-) Deger Sil");
                Console.WriteLine("6-) Cikis");
                Console.Write("Seciminiz: ");
                secim = Console.ReadLine();

                switch (secim)
                {
                    case "1":
                        Console.Write("Eklenecek Deger: ");
                        string eklenecekDeger = Console.ReadLine();
                        degerListesi.Add(eklenecekDeger);
                        Console.WriteLine("Deger Eklendi.");
                        Console.Write("Devam etmek icin ENTER basin.");
                        Console.ReadLine();
                        break;
                    case "2":
                        Console.WriteLine("Deger Listesi: ");
                        foreach (var item in degerListesi)
                        {
                            Console.WriteLine(item);
                        }
                        Console.Write("Listeleme Tamamlandi. \n Devam etmek icin ENTER basin.");
                        Console.ReadLine();
                        break;
                    case "3":
                        Console.Write("Aranacak Deger: ");
                        string aranacakDeger = Console.ReadLine();
                        if (degerListesi.Contains(aranacakDeger)) Console.WriteLine("Deger Bulundu. Deger {0}. indexte.", degerListesi.IndexOf(aranacakDeger));
                        else
                        {
                            Console.WriteLine("Deger Bulunamadi.");
                            Console.Write("Listeye eklensin mi? (E/H): ");
                            string ekleSecim = Console.ReadLine();
                            if (ekleSecim.ToUpper() == "E")
                            {
                                degerListesi.Add(aranacakDeger);
                                Console.WriteLine("Deger Listeye eklendi.");
                            }
                            else Console.WriteLine("Islem iptal edildi.");
                        }
                        Console.Write("Devam etmek icin ENTER basin.");
                        Console.ReadLine();
                        break;
                    case "4":
                        Console.Write("Guncellemek istediginiz degeri girin: ");
                        string guncellenecekDeger = Console.ReadLine();
                        if (degerListesi.Contains(guncellenecekDeger))
                        {
                            Console.Write("{0} degerini hangi deger ile guncellemek istiyorsunuz: ", guncellenecekDeger);
                            string yeniDeger = Console.ReadLine();
                            degerListesi[degerListesi.IndexOf(guncellenecekDeger)] = yeniDeger;
                            Console.WriteLine("Deger Guncellendi.");
                        }
                        else Console.WriteLine("Deger Bulunamadi.");
                        Console.Write("Devam etmek icin ENTER basin.");
                        break;
                    case "5":
                        Console.Write("Silinecek Deger: ");
                        string silinecekDeger = Console.ReadLine();
                        if (degerListesi.Contains(silinecekDeger))
                        {
                            degerListesi.Remove(silinecekDeger);
                            Console.WriteLine("Deger Silindi.");
                        }
                        else Console.WriteLine("Deger Bulunamadi.");
                        Console.Write("Devam etmek icin ENTER basin.");
                        Console.ReadLine();
                        break;
                    default:
                        Console.Write("Yanlis Secim \n basa donuluyor...");
                        System.Threading.Thread.Sleep(1000);
                        break;
                }
                Console.Clear();
            } while (secim != "6");
            */

            //------------------------------------------------------- Hashtable

            //Hashtable ingTrSozluk = new Hashtable();

            //string secim = "";
            //do
            //{
            //    Console.Write("Islem Yapmak istiyor musunuz E/H: ");
            //    secim = Console.ReadLine().ToUpper();
            //    if (secim == "E")
            //    {
            //        Console.WriteLine("Key Giriniz: ");
            //        string key = Console.ReadLine();
            //        Console.WriteLine("Value Giriniz: ");
            //        string value = Console.ReadLine();
            //        if (ingTrSozluk.ContainsKey(key)) Console.WriteLine("Eklemek istediginiz key veri tabaninda bulunmakta.");
            //        else ingTrSozluk.Add(key, value);
            //    }
            //    else if (secim == "H")
            //    {
            //        foreach (DictionaryEntry item in ingTrSozluk)
            //        {
            //            Console.WriteLine(item.Key + " - " + item.Value);
            //        }
            //        Console.WriteLine("Cikis yapmak icin ENTER");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Yanlis bir secim yaptiniz. ");
            //        Console.Clear();
            //        continue;
            //    }

            //} while (secim != "H");


            //Console.ReadLine();


            //------------------------------------------------------- Diğer Listeler

            //SortedList İşlendi. Hashtable ile hemen hemen aynı. Farkı sıralı olması. Küçükten büyüğe veya A'dan Z'ye sıralar. Key ve Value değerlerini alır. Key değeri bağımsız olmalıdır.
            // Key değerine sadece aynı tür eklenebilir(Örneğin string başlandıysa string ile devam eder. Int başlandıysa int ile devam eder.)

            //Stack İşlendi. LIFO (Last In First Out) mantığı ile çalışır. Yığın mantığı ile çalışır. Push ve Pop metotları ile çalışır. Push ile eleman eklenir. Pop ile eleman çıkarılır.
            // Peek metodu ile en üstteki elemanı görebiliriz. Count ile eleman sayısını alabiliriz. 

            //Queue İşlendi. FIFO (First In First Out) mantığı ile çalışır. Kuyruk mantığı ile çalışır. En son eklenen eleman en önce çıkar. En önce eklenen eleman en son çıkar.
            // Enqueue ile eleman eklenir. Dequeue ile eleman çıkarılır. Peek ile en üstteki elemanı görebiliriz. Count ile eleman sayısını alabiliriz.


            //------------------------------------------------------- Metot Genel Tanım

            SelamVer("Enis");
        }

        static void SelamVer(string isim)
        {
            Console.WriteLine("Selam {0}!", isim);

        }
    }
}
