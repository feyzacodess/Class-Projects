namespace PROJE1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // GİRİLEN İKİ SAYININ TOPLAMINI BULAN PROGRAM

            int Sayi1;
            int Sayi2;
            string Metin1;
            string Metin2;

            Console.Write("1. Sayıyı Giriniz: ");
            Metin1 = Console.ReadLine();
            Sayi1 = Convert.ToInt32(Metin1);

            Console.Write("2. Sayıyı Giriniz: ");
            Metin2 = Console.ReadLine();
            Sayi2 = Convert.ToInt32(Metin2);

            int Sonuc = Sayi1 + Sayi2;

            Console.WriteLine(Sonuc.ToString());
        }
    }
}
