using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            string kullaniciSecim = string.Empty;
            ArrayList degerListesi = new ArrayList();
            do
            {
                Console.Clear();
                Console.WriteLine("Menü");
                Console.WriteLine("1 - Değer Ekle");
                Console.WriteLine("2 - Değer Listele");
                Console.WriteLine("3 - Değer Ara");
                Console.WriteLine("4 - Değer Düzenle");
                Console.WriteLine("5 - Değer Sil");
                Console.WriteLine("6 - Uygulamadan Çıkış");
                Console.Write("Seçiniz : ");
                kullaniciSecim = Console.ReadLine();

                switch (kullaniciSecim)
                {
                    case "1":
                        Console.Write("Lütfen eklemek istediğiniz değeri giriniz : ");
                        string kullaniciDeger = Console.ReadLine();
                        degerListesi.Add(kullaniciDeger);
                        Console.WriteLine("Değeriniz başarılı bir şekilde eklendi.");
                        System.Threading.Thread.Sleep(2000);
                        break;
                    case "2":
                        for (int i = 0; i < degerListesi.Count; i++)
                        {
                            Console.WriteLine("{0}. değer : {1}", i, degerListesi[i]);
                        }
                        Console.WriteLine("Devam etmek için herhangi bir tuşa basınız.");
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.WriteLine("Aramak istediğiniz değeri giriniz");
                        string kullaniciAramaDeger = Console.ReadLine();
                        bool kontrol = degerListesi.Contains(kullaniciAramaDeger);
                        if (kontrol)
                        {
                            int bulunanIndex = degerListesi.IndexOf(kullaniciAramaDeger);
                            string bulunanDeger = degerListesi[bulunanIndex].ToString();
                            Console.WriteLine("Değeriniz bulundu. Bulunan index : {0} - Bulunan değer : {1}", bulunanIndex, bulunanDeger);
                        }
                        else
                        {
                            Console.WriteLine("Aradığınız değer bulunamadı.");
                        }
                        break;
                    case "4":
                        break;
                    case "5":
                        break;
                    default:
                        break;
                }
            } while (kullaniciSecim != "6");
        }
    }
}
