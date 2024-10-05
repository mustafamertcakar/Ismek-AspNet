using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnBüyükSayi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("ilk sayıyı giriniz :");
            //int ilkSayi=int.Parse(Console.ReadLine());

            //Console.Write("ikinci sayıyı giriniz :");
            //int ikinciSayi=int.Parse(Console.ReadLine());

            //Console.Write("Üçüncü sayıyı giriniz :");
            //int ucuncuSayi=int.Parse(Console.ReadLine());

            //int karsilastirma1 = 0;
            //if (ilkSayi>ikinciSayi)
            //{
            //    karsilastirma1 = ilkSayi;
            //}
            //else
            //{
            //    karsilastirma1 = ikinciSayi;
            //}


            //int karsilastirma2 = 0;
            //if (ucuncuSayi>karsilastirma1)
            //{
            //    karsilastirma2 = ucuncuSayi;
            //}
            //else
            //{
            //    karsilastirma2 = karsilastirma1;
            //}
            //Console.WriteLine(karsilastirma2);
            //Console.Read();



            Console.Write("1.Sayıyı giriniz :");
            int sayi1= Convert.ToInt32(Console.ReadLine());
            Console.Write("2. Sayıyı giriniz :");
            int sayi2 = Convert.ToInt32(Console.ReadLine());    7,
            Console.Write("3. Sayıyı giriniz :");
            int sayi3= Convert.ToInt32(Console.ReadLine());

            int Eb = sayi1;
            if (sayi2 > Eb) Eb = sayi2;
            if (sayi3 > Eb) Eb = sayi3;

            Console.WriteLine("Girilen En Büyük Sayı = "+ Eb);
            Console.Read();
 


        }
    }
}
