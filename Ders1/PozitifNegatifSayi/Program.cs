using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PozitifNegatifSayi
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //Atölye defteri al.temrin vs proje defteri

        Basla:;
            try { 

                Console.Write("Bir sayı giriniz :");
                int sayi = int.Parse(Console.ReadLine());


                if (sayi > 0)
                {
                    Console.WriteLine("Sayı pozitif");
                }
                else if (sayi < 0)
                {
                    Console.WriteLine("Sayı negatif");
                }
                else
                {
                    Console.WriteLine("Girdiğiniz sayı 0'a eşittir.");
                }
                Console.Read();
            }

            catch (Exception e)
            {
                Console.WriteLine("Girdiğiniz ifade bir sayı değil.");
                goto Basla; ;
                Console.Read();
                
            }
        }
    }
}
