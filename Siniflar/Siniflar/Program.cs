using System;

namespace Siniflar
{
    class Program
    {
        static void Main(string[] args)
        {

            //erişi belirleyiciler
            //public
            //private
            //protected
            Calısan calışan1 = new Calısan();
            calışan1.Ad = "Özlem";
            calışan1.Soyad = "yılmaz";
            calışan1.No = 1234;
            calışan1.Depertman = "Yazılım";
            calışan1.CalısanBilgileri();

            Console.WriteLine("*******************");

            Calısan calışan2 = new Calısan();
            calışan2.Ad = "Ayşe";
            calışan2.Soyad = "Kara";
            calışan2.No = 23445566;
            calışan2.Depertman = "İnsan Kaynakları";
            calışan2.CalısanBilgileri();
        }
    }
    class Calısan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Depertman;

        public void CalısanBilgileri()
        {
            Console.WriteLine("Çalışan adı: " + Ad);
            Console.WriteLine("Çalışan soyadı: " + Soyad);
            Console.WriteLine("Çalışan numarası: " + No);
            Console.WriteLine("Çalışanın depertmanı: " + Depertman);
        }
    }
}
