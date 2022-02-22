using System;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Calısan calışan1 = new Calısan("Özlem", "Yılmaz", 1234, "Yazılım");

            calışan1.CalısanBilgileri();

            Console.WriteLine("*******************");

            Calısan calışan2 = new Calısan();
            calışan2.Ad = "Ayşe";
            calışan2.Soyad = "Kara";
            calışan2.No = 23445566;
            calışan2.Depertman = "İnsan Kaynakları";
            calışan2.CalısanBilgileri();

            Calısan calışan3 = new Calısan("Zikriye", "Ürkmez");

            calışan3.CalısanBilgileri();
        }
     }
    class Calısan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Depertman;

        public Calısan(string ad, string soyad, int no, string depertman)
        {
            this.Ad = ad;
            this.Soyad = soyad;
            this.No = no;
            this.Depertman = depertman;
        }
        public Calısan(string ad, string soyad)
        {
            this.Ad = ad;
            this.Soyad = soyad;
           
        }
        public Calısan() { }
        public void CalısanBilgileri()
        {
            Console.WriteLine("Çalışan adı: " + Ad);
            Console.WriteLine("Çalışan soyadı: " + Soyad);
            Console.WriteLine("Çalışan numarası: " + No);
            Console.WriteLine("Çalışanın depertmanı: " + Depertman);
        }
    }
    
}
