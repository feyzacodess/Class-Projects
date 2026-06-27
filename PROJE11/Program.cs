namespace PROJE11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  GİRİLEN METNİ TERSTEN YAZAN C# KODU  

            try
            {
                Console.Write("metni giriniz: ");
                string Metin = Console.ReadLine();

                string TersMetin = "";
                for (int i = Metin.Length - 1; i >= 0; i--)
                {
                    TersMetin += Metin[i].ToString();
                }

                Console.WriteLine("Girilen \"{0}\" metinin tersten yazılışı \"{1}\".",Metin, TersMetin);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata : {0}", ex.ToString());
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
