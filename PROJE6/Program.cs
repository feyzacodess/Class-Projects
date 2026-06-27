namespace PROJE6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 İLE 10 ARASINDAKİ SAYILARDAN 3 E VE 5 E TAM BÖLÜNEN SAYILARI BULARAK 
            //ARAYA BOŞLUK KOYUP EKRANA YAZAN KOD. 

            try
            {
                string Sonuc = "";
                for (int i = 1; i <= 10; i++)
                {
                    if (i % 3 == 0 || i % 5 == 0)
                    {
                        Sonuc += i.ToString() + " ";
                    }
                }
                Console.WriteLine("1 İLE 10 ARASINDAKİ 3'E VE 5'E TAM BÖLÜNEN SAYILAR : {0}", Sonuc.Trim()); 
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
