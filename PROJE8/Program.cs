namespace PROJE8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //KULLANICI TARAFINDAN TAM SAYI OLARAK DEĞERLERİNİ GİRİLEN 3 ELEMANLI BİR 
            //DİZİNİN EN BÜYÜK ELEMANINI BULARAK EKRANA YAZAN KOD



            try
            {
                int[] SayiDizisi = new int[3];

                for (int i = 0; i < SayiDizisi.Length; i++)
                {
                    Console.Write("Dizinin {0}. Elamanını Giriniz :", i);
                    string Metin = Console.ReadLine();
                    SayiDizisi[i] = Convert.ToInt32(Metin);
                }
                int EnBuyuk = SayiDizisi[0];
                string SayiMetin = "";

                foreach (int Sayi in SayiDizisi)
                {
                    if (Sayi > EnBuyuk)
                    {
                        EnBuyuk = Sayi;
                    }

                    SayiMetin += SayiMetin.ToString() + "-";
                }
                Console.WriteLine("Girilen {0} sayıların arasındaki en büyük sayı {1} sayısıdır.", SayiMetin.Trim('-'), EnBuyuk);
            }
            catch (Exception ex)
            {
                Console.WriteLine("HATA :{0}", ex.ToString());
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
