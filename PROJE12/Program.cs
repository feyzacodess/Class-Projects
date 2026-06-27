namespace PROJE12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //metnin palindrom olup olmadığını bulan kod 

            try
            {
                Console.Write("Metni Giriniz : ");
                string Metin = Console.ReadLine();

                string TersMetin = " ";
                for (int i = Metin.Length - 1; i >= 0; i--)
                {
                    TersMetin += Metin[i].ToString();
                }

                if (Metin == TersMetin)
                {
                    Console.WriteLine("Girilen \"{0}\" metnin tersten yazılışı \"{1}\" olduğu için girilen metin palindromdur.", Metin, TersMetin); 
                }
                else
                {
                    Console.WriteLine("Girilen \"{0}\" metnin tersten yazılışı \"{1}\" olduğu için girilen metin palindrom değildir.", Metin, TersMetin); 
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("HATA : {0}", ex.ToString());
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
