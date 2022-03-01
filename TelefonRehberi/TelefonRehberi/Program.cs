using System;
using System.Collections.Generic;

namespace TelefonRehberi
{
    class Program
    {
        static void Main(string[] args)
        {
            Rehberİşlemler islem1 = new Rehberİşlemler();
            islem1.TemelKullanıcı();

            while (true)
            {
                Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçin :)");
                Console.WriteLine("***************************************");
                Console.WriteLine("(1) Yeni Numara Kaydetmek");
                Console.WriteLine("(2) Varolan Numarayı Silmek");
                Console.WriteLine("(3) Varolan Numarayı Güncelleme");
                Console.WriteLine("(4) Rehberi Listelemek");
                Console.WriteLine("(5) Rehberde Arama Yapmak﻿");
                Console.WriteLine("(6) Çıkış Yap");


                Console.Write("İslemlerden birini seçiniz (1-2-3-4-5-6)");
                //
                int tercih = Convert.ToInt32(Console.ReadLine());
                if (tercih == 1)
                {
                    islem1.NoKaydet();
                    Console.WriteLine("**********************************************");
                }
                else if (tercih == 2)
                {
                    islem1.NoSil();
                    Console.WriteLine("**********************************************");
                }
                else if (tercih == 3)
                {
                    islem1.NoGüncelle();
                    Console.WriteLine("**********************************************");
                }
                else if (tercih == 4)
                {
                    islem1.RehberListele();
                    Console.WriteLine("**********************************************");
                }
                else if (tercih == 5)
                {
                    islem1.RehberArama();
                    Console.WriteLine("**********************************************");
                }
                else if (tercih == 6)
                {
                    break;
                }
            }
            


        }
    }
    class Kisi
    {
        private string ad;
        private string soyad;
        private string no;

        public string No { get => no; set => no = value; }
        public string Soyad { get => soyad; set => soyad = value; }
        public string Ad { get => ad; set => ad = value; }

        public Kisi(string ad, string soyad, string no)
        {
            this.Ad = ad;
            this.Soyad = soyad;
            this.No = no;

        }
        public Kisi()
        {

        }
        public void KullaniciGetir()
        {
            Console.WriteLine("isim: {0}", Ad);
            Console.WriteLine("Soyisim: {0}", Soyad);
            Console.WriteLine("Telefon Numarası: {0}", No);
            Console.WriteLine("-".PadLeft(30, '-'));
        }
    }
    static class Rehber
    {
        public static List<Kisi> rehberliste = new List<Kisi>();
    }
    class Rehberİşlemler
    {
        public bool Kontrol(string metin1)
        {
            Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
            Console.WriteLine(metin1);
            Console.WriteLine("* Yeniden denemek için      : (2)");
            int tercih = Convert.ToInt32(Console.ReadLine());
            if (tercih == 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public void TemelKullanıcı()
        {
            Rehber.rehberliste.Add(new Kisi("özlem", "yılmaz", "123456"));
            Rehber.rehberliste.Add(new Kisi("necla", "kara", "54213648"));
            Rehber.rehberliste.Add(new Kisi("özge", "yılmaz", "631458745"));
            Rehber.rehberliste.Add(new Kisi("çiğdem", "yılmaz", "32594621"));
            Rehber.rehberliste.Add(new Kisi("samed", "demir", "3115478625"));
        }
        public void NoKaydet()
        {
            Console.WriteLine("Yeni kişi oluştur");
            Console.Write("Lütfen isim giriniz             :");
            string ad = Console.ReadLine();
            Console.Write("Lütfen soyisim giriniz          :");
            string soyad = Console.ReadLine();
            Console.Write("Lütfen telefon numarası giriniz :");
            string no = Console.ReadLine();
            Rehber.rehberliste.Add(new Kisi(ad, soyad, no));
        }
        public void NoSil()
        {
            while (true)
            {
                Console.Write("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
                string metin = "* Silmeyi sonlandırmak için : (1)";
                string arama_metni = Console.ReadLine();
                var v = (arama_metni);
                if (v == null)
                {
                    if (Kontrol(metin) == false)
                    {
                        break;
                    }
                }
                else
                {
                    Console.Write("{0} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)");
                    if (Console.ReadLine().ToLower() == "y")
                    {
                        Rehber.rehberliste.Remove(RehberArama(arama_metni));
                        break;
                    }
                    else
                    {
                        break;
                    }

                }

            }
        }
        public void NoGüncelle()
        {
            while (true)
            {
                Console.Write("Lütfen  güncellemek istediğiniz kişinin adını ya da soyadını giriniz:");
                string metin = "* Güncellemeyi sonlandırmak için : (1)";
                string arama_metni = Console.ReadLine();
                var v = RehberArama(arama_metni);
                if (v == null)
                {
                    if (Kontrol(metin) == false)
                    {
                        break;
                    }
                }
                else
                {
                    v.KullaniciGetir();
                    Console.Write("Yeni No:");
                    v.No = Console.ReadLine();
                    break;
                }

            }
        }
        public void RehberListele()
        {
            foreach (var v in Rehber.rehberliste)
            {
                v.KullaniciGetir();
            }

        }
        public Kisi RehberArama(string arananMetin)
        {
            foreach (var v in Rehber.rehberliste)
            {
                if (v.Ad == arananMetin | v.Soyad == arananMetin)
                {
                    return v;
                }

            }
            return null;
        }
        public void RehberArama()
        {
            Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
            Console.WriteLine("**********************************************");
            Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
            Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");
            int a = Convert.ToInt16(Console.ReadLine());
            Console.Write("Arancak metin:");
            string arananMetin = Console.ReadLine();
            if (a == 1)
            {
                foreach (var v in Rehber.rehberliste)
                {
                    if (v.Ad == arananMetin | v.Soyad == arananMetin)
                    {
                        v.KullaniciGetir();
                    }
                }
            }
            else if (a == 2)
            {
                foreach (var v in Rehber.rehberliste)
                {
                    if (v.No == arananMetin)
                    {
                        v.KullaniciGetir();
                    }
                }
            }
        }
     
        public Rehberİşlemler()
        {
        }
    }
        
    

}
