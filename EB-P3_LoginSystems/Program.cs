using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_GirisUygulamasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int HakSayisi = 3;

            while (true)
            {
                Console.WriteLine("Kullanıcı Adınızı Giriniz");
                String KullaniciAdi = Console.ReadLine();

                Console.WriteLine("Şifrenizi Giriniz");
                string Sifre = Console.ReadLine();

                if (KullaniciAdi == "Fatih" && Sifre == "123")
                {
                    Console.WriteLine("Tebrikler Başarılı Bir Şekilde Giriş Yaptınız");
                    break;

                }
                else
                {
                    Console.WriteLine("Kullanıcı Adı ve Şifreniz Hatalı");

                    if (HakSayisi > 0)
                    {
                        HakSayisi -= 1;

                    }
                    if (HakSayisi == 0)
                    {
                        Console.WriteLine("Hakkınız Dolmuştur, Sisteme Giriş Yapamazsınız.");
                        break;

                    }

                }

            }
            Console.ReadLine();


        }

    }


}




