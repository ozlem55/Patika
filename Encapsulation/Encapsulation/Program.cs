using System;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Isim = "Özlem";
            ogrenci.Soyisim = "Yılmaz";
            ogrenci.OgrenciNo = 922;
            ogrenci.Sınıf = 3;

            ogrenci.SınıfAtlat();
            ogrenci.SınıfDüşür();
      
            ogrenci.OgrenciBilgileriGetir();

            Ogrenci ogrenci2 = new Ogrenci("Deniz","Arda",123,1);
  

            ogrenci2.SınıfDüşür();
            ogrenci2.SınıfDüşür();

            ogrenci2.OgrenciBilgileriGetir();
        }
    }
    class Ogrenci
    {
        private string isim;
        private string soyisim;
        private int ogrenciNo;
        private int sınıf;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
        public int Sınıf { get => sınıf;
            set
            {
                if (value < 1)
                {
                    Console.WriteLine("Sınıf en az 1 olabilir");
                }
                else
                    sınıf = value;
            }
            }

        public Ogrenci() { }
        public Ogrenci(string ısim, string soyisim, int ogrenciNo, int sınıf)
        {
            Isim = ısim;
            this.soyisim = soyisim;
            this.ogrenciNo = ogrenciNo;
            this.sınıf = sınıf;
        }
        public void OgrenciBilgileriGetir()
        {
            Console.WriteLine("******Öğrenci Bilgileri******");
            Console.WriteLine("Öğrenci ad: {0}", this.Isim);
            Console.WriteLine("Öğrenci soyad: {0}", this.Soyisim);
            Console.WriteLine("Öğrenci numara: {0}", this.OgrenciNo);
            Console.WriteLine("Öğrenci sınıf: {0}", this.Sınıf);
        }

        public void SınıfAtlat()
        {
            this.Sınıf = this.Sınıf + 1;
        }
        public void SınıfDüşür()
        {
            this.Sınıf = this.Sınıf - 1;
           
        }
    }
}
