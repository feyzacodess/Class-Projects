namespace PROJE7
{
    internal class Program
    {
        static void Main(string[] args)             
        {
            // ÜÇ ELEMANLI BİR DİZİYE KULLANICI TARAFINDAN TAM SAYI DEĞERLERİ ATANAN 
            //VE DAHA SONRA BU ATANAN DEĞERLERİ TOPLAYIP SONUCUNU EKRANA YAZAN KODU YAZINIZ. 
            
            try
            {
                int[] SayiDizisi = new int[3];
                for (int i = 0; i < SayiDizisi.Length; i++)
                {
                    Console.Write("Sayi dizisinin {0}. elemanını giriniz : ", i);
                    string Metin = Console.ReadLine();
                    SayiDizisi[i] = Convert.ToInt32(Metin);
                }
                int Toplam = 0;

                for (int i = 0; i < SayiDizisi.Length; ++i)
                {
                    Toplam += SayiDizisi[i];
                }
                Console.WriteLine("Sayı dizisinin elemanları toplamı {0}'dır.",Toplam);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lütfen geçerli bir tam sayı giriniz.");
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
