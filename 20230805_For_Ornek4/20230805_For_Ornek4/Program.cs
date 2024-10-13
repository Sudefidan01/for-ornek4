using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230805_For_Ornek4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ornek 4
            //1'den başlayıp kullanıcının girdiği sayıya kadar olan sayıların toplam ve ortalamasını yazdıralım
            int toplam = 0;
            int kullaniciSayi;
            Console.Write("Bir Sayı Giriniz : ");
            kullaniciSayi = int.Parse(Console.ReadLine());

            for (int i = 1; i <= kullaniciSayi; i++)
            {
                toplam += i; // toplam= toplam + i ;
            }
            double ortalama = (double)toplam / kullaniciSayi;
            Console.WriteLine("1'den Girdiğiniz sayılara kadar olan sayıların toplamı : " + toplam);
            Console.WriteLine("Sayıların Ortalaması : " + ortalama);

            Console.ReadKey();
        }
    }
}
