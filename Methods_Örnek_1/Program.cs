namespace Methods_Örnek_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kullanıcıdan alınacak 2 ürün fiyatından pahalı olana %30 indirim uygulayan metot 
            //ve 3.ürün almak isterse 3.ürüne %50 indirim uygulayarak metot ile kodlayınız

            İndirim();
        }

        static void İndirim()
        {
            Console.WriteLine("1.Ürün Fiyatı");
            double urunFiyat1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("2.Ürün Fiyatı");
            double urunFiyat2 = Convert.ToDouble(Console.ReadLine());

            if (urunFiyat1 > urunFiyat2) // eğer fiyat1 fiyat2 den büyükse fiyat1 e yüzde 30 indirim hesaplanıyor.
            {
                urunFiyat1 *= 0.7;
            }
            else // eğer fiyat2 daha büyükse , fiyat2 yüüzde 30 indirim üstünden hesaplanıyor
            {
                urunFiyat2 *= 0.7;
            }

            Console.WriteLine($"İndirimli Fiyatlar: 1. Ürün: {urunFiyat1}, 2. Ürün: {urunFiyat2}");

            Console.WriteLine("3.Ürünü Almak İster Misiniz?(E/H)");
            string cevap = Console.ReadLine().ToUpper();

            if (cevap == "E")
            {
                Indirim3(urunFiyat1, urunFiyat2);
            }

            else
            {
                Console.WriteLine("Ödeme:" + (urunFiyat2 + urunFiyat1));
            }
        }
        static void Indirim3(double indirimliFiyat1, double indirimliFiyat2)
        {
            Console.WriteLine("3.Ürün Fiyatı:");
            double urunFiyati3 = Convert.ToDouble(Console.ReadLine()); 

            urunFiyati3 *= 0.5; 

            Console.WriteLine($"3. Ürün İndirimli Fiyat {urunFiyati3}");

            double toplamOdeme = indirimliFiyat1 + indirimliFiyat2 + urunFiyati3;
            Console.WriteLine($"Toplam Ödeme (3. Ürün Dahil): {toplamOdeme}");
        }
    }
}
