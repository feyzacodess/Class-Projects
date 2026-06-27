namespace PROJE3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 İLE 10 ARASINDAKİ SAYILARIN TOPLAMINI BULAN PROGRAM
            try
            {
                int Sonuc = 0;

                for (int i = 1; i <= 10; i++)
                {
                    Sonuc += i;
                }
                Console.WriteLine("1 ile 10 arasındaki sayıların toplamı {0} olur.",Sonuc);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
