using System;

namespace OutAnahtarKelimesi
{
    class Program
    {
        /* Bu uygulama ref anahtar sözcüğünü anlatmak için kullanılan uygulama ile aynı. Sadece out kullanılmış hale çevrildi. */
        static void Main(string[] args)
        {
            // ref ile farkları; 
            // fiyat değişkeni main içerisinde bir değer almak zorunda değildir. ref' de bu şekilde bir kullanım yapılırsa hata alırız.
            // Ancak metotta kullanılan herbir parametre, metotun içinde bir değer ataması istemektedir. Parametrelere atanan bir değer yoksa hata verir. Ref' in böyle bir kullanım şartı yoktur.

            double fiyat;
            double kdv = 0.18;
            var result = FiyatHesapla(out fiyat, out kdv);

            Console.WriteLine(string.Format("KDV: {0}, Kitap Fiyatı: {1}, Kitap Satış Fiyatı: {2}", kdv, fiyat, result));

        }

        static double FiyatHesapla(out double kitapFiyat, out double kdv)
        {
            kitapFiyat = 20.0;
            kdv = 0.18;
            bool degisiklik;
            Console.Write("Fiyatta ve KDV'de değişiklik yapmak ister misiniz? => ");
            degisiklik = Convert.ToBoolean(Console.ReadLine());
            if (degisiklik)
            {
                Console.Write("Kitap Fiyatını Giriniz: ");
                kitapFiyat = Convert.ToDouble(Console.ReadLine());
                Console.Write("KDV bilgisini giriniz: ");
                kdv = Convert.ToDouble(Console.ReadLine());
                return kitapFiyat + (kitapFiyat * kdv);
            }
            else
            {
                return kitapFiyat + (kitapFiyat * kdv);
            }

        }

    }
}
