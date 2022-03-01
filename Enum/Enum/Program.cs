using System;

namespace Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Gunler.Pazartesi);
            Console.WriteLine((int)Gunler.Cumartesi);

            int sıcaklık = 32;
            if (sıcaklık <= (int)HavaDurumu.Normal)
            {
                Console.WriteLine("Dışarı çıkmak için havanın biraz daha ısınmasını bekleyin.");

            }
            else if(sıcaklık>=(int)HavaDurumu.Sıcak)
            {
                Console.WriteLine("Dışarı çıkmak için çok sıcak bir gün");
            }
            else if (sıcaklık >= (int)HavaDurumu.Normal && sıcaklık<(int)HavaDurumu.CokSıcak)
            {
                Console.WriteLine("Hadi dışarı çıkalım.");
            }
           
        }
    }
    enum Gunler
    {
        Pazartesi=1,
        Salı,
        Çarşamba,
        Perşembe,
        Cuma=23,
        Cumartesi,
        Pazar
    }
    enum HavaDurumu
    {
        Soguk=5,
        Normal=20,
        Sıcak=25,
        CokSıcak=30
    }
}
