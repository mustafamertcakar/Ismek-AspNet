using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToplamYaz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Toplamını bulmak istediğiniz sayı miktarını giriniz: ");
            //int kullanıcıSayiAdeti = Convert.ToInt32(Console.ReadLine());

            //int toplam = 0;
            //for (int i = 0; i < kullanıcıSayiAdeti; i++)
            //{
            //    Console.Write("Bir sayı giriniz :");
            //    int sayi = Convert.ToInt32(Console.ReadLine());

            //    toplam += sayi;
            //}
            //Console.WriteLine(toplam);
            //Console.Read();



            int sayi;
            int toplam = 0;
            for (int i = 1;i<11;i++)
            {
                Console.Write(i+"."+"sayıyı giriniz :");
                sayi=Convert.ToInt32(Console.ReadLine());
                toplam += sayi;
            }
            Console.WriteLine(toplam);
            Console.Read();
        }
    }
}
