namespace PROJE2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // İKİ SAYININ ARİTMETİK ORTALAMASINI BULAN PROGRAM

            double sayi1;
            double sayi2;
            string Metin1;
            string Metin2;
            double Sonuc;

            Console.WriteLine("1. sayıyı giriniz: ");
            Metin1 = Console.ReadLine();
            sayi1 = Convert.ToDouble(Metin1);

            Console.WriteLine("2. sayıyı giriniz: ");
            Metin2 = Console.ReadLine();
            sayi2 = Convert.ToDouble(Metin2);

            Sonuc = sayi1 + sayi2 / 2d;

            Console.WriteLine("Girilen sayıların aritmetik ortalaması {0} olur", sayi1, sayi2, Sonuc);

        }
    }
}
