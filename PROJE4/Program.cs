namespace PROJE4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 İLE 10 ARASINDAKİ TEK SAYILARIN TOPLAMINI BULAN PROGRAM
            try
            {
                int Sonuc = 0;

                for (int i = 1; i <= 10; i++)
                {
                    if (i % 2 != 0)
                    {
                        Sonuc += i;
                    }
                }
                Console.WriteLine("1 ile 10 arsındaki tek sayıların toplamı {0}' dır",Sonuc);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
