using System;

namespace KrediSistemi
{
    // Kredi hesaplama arayüzü
    public interface IKredi
    {
        decimal Hesapla(decimal anapara, int vade);
    }

    // Konut Kredisi
    public class KonutKredisi : IKredi
    {
        private const decimal FaizOrani = 0.015m; // %1.5 aylık faiz oranı

        public decimal Hesapla(decimal anapara, int vade)
        {
            return anapara * (1 + FaizOrani * vade);
        }
    }

    // Taşıt Kredisi
    public class TasitKredisi : IKredi
    {
        private const decimal FaizOrani = 0.02m; // %2 aylık faiz oranı

        public decimal Hesapla(decimal anapara, int vade)
        {
            return anapara * (1 + FaizOrani * vade);
        }
    }

    // İhtiyaç Kredisi
    public class IhtiyacKredisi : IKredi
    {
        private const decimal FaizOrani = 0.025m; // %2.5 aylık faiz oranı

        public decimal Hesapla(decimal anapara, int vade)
        {
            return anapara * (1 + FaizOrani * vade);
        }
    }

    // Kredi Hesaplama Testi
    class Program
    {
        static void Main(string[] args)
        {
            IKredi konutKredisi = new KonutKredisi();
            IKredi tasitKredisi = new TasitKredisi();
            IKredi ihtiyacKredisi = new IhtiyacKredisi();

            decimal anapara = 100000;
            int vade = 12;

            Console.WriteLine("Konut Kredisi Toplam Ödeme: " + konutKredisi.Hesapla(anapara, vade));
            Console.WriteLine("Taşıt Kredisi Toplam Ödeme: " + tasitKredisi.Hesapla(anapara, vade));
            Console.WriteLine("İhtiyaç Kredisi Toplam Ödeme: " + ihtiyacKredisi.Hesapla(anapara, vade));
        }
    }
}
