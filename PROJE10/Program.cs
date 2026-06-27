namespace PROJE10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1'e VE KENDİSİNDEN BAŞKA BİR SAYIYA TAM OLARAK BÖLÜNMEYEN SAYILARA ASAL SAYI DENİR. KULLANICI TARAFINDAN GİRİLEN BİR SAYININ EKRANA "ASALDIR" YADA "ASAL 
            //DEĞİLDİR" YAZAN KOD. 
            // SAYILARA ASAL SAYI DENİR. KULLANICI TARAFINDAN GİRİLEN BİR SAYININ 
            //EKRANA "ASALDIR" YADA "ASAL DEĞİLDİR" YAZAN KOD. 
            // (KULLANICI 2 DEN BÜYÜK 3 VE 3 DEN BÜYÜK SAYILAR GİRMEKTEDİR) 

            try
            {
                Console.Write("Sayıyı Giriniz : ");
                string Metin = Console.ReadLine();
                int Sayi = Convert.ToInt32(Metin);

                bool AsalMi = true;

                for (int i = 2; i < Sayi; i++)
                {
                    if (Sayi % i == 0)
                    {
                        AsalMi = false;
                    }
                }
                if (AsalMi == true)
                {
                    Console.WriteLine("{0} sayısı asaldır.", Sayi);
                }
                else
                {
                    Console.WriteLine("{0} sayısı asal değildir.", Sayi);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("HATA : {0}", ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
