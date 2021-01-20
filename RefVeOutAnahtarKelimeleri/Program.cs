using System;

namespace RefAnahtarKelimesi
{
    class Program
    {
        /* Bu uygulamada kitap fiyatı ve kdv parametreleri main'den gönderilecek. Metot çalıştığında bu fiyatları değiştirmek isteyip istemediğimiz sorulacak. Biz ref'i gözlemleyebilmek için değişiklik yapmak istediğimizi söyleyeceğiz ve main'de bu değerleri tekrar çağırarak, ref anahtar sözcüğü ile değişikliklerin korunduğunu gözlemleyeceğiz.  */
        static void Main(string[] args)
        {
            double fiyat = 20.0;
            double kdv = 0.18;
            var result = FiyatHesapla(ref fiyat, ref kdv);

            Console.WriteLine(string.Format("KDV: {0}, Kitap Fiyatı: {1}, Kitap Satış Fiyatı: {2}", kdv, fiyat, result));

        }

        static double FiyatHesapla(ref double kitapFiyat, ref double kdv)
        {
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
