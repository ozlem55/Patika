using System;

namespace StaticSinifveÜyeler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Çalışan sayısı: {0} ", Calışan.CalışanSayısı);

            Calışan calışan = new Calışan("Özlem","Yılmaz","İk");
            Console.WriteLine("Çalışan sayısı: {0} ", Calışan.CalışanSayısı);
            Calışan calışan2 = new Calışan("Samed", "Demir", "IT");
            Calışan calışan3 = new Calışan("Deniz", "Arda", "İk");
            Console.WriteLine("Çalışan sayısı: {0} ", Calışan.CalışanSayısı);

            
            Console.WriteLine("Toplama işleminin sonucu: {0}", Işlemler.Topla(2, 5));
            Console.WriteLine("Toplama işleminin sonucu: {0}", Işlemler.Çıkar(100, 50));
          
        }
    }
    class Calışan
    {
        private static int calışanSayısı;

        public static int CalışanSayısı { get => calışanSayısı; }

        private string Isım;
        private string SoyIsım;
        private string Depertman;

        static Calışan()
        {
            calışanSayısı = 0;
        }

        public Calışan(string ısım, string soyIsım, string depertman)
        {
            this.Isım = ısım;
            this.SoyIsım = soyIsım;
            this.Depertman = depertman;
            calışanSayısı += 1;
        }
    }
    static class Işlemler
    {
        public static long Topla(int sayi1,int sayi2)
        {
            return sayi1 + sayi2;
        }
        public static long Çıkar(int sayi1, int sayi2)
        {
            return sayi1 - sayi2;
        }
    }
}
