using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İlPlakaKodu
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //string olarak da tanımlanabilirdi.
            Console.Write("Öğrenmek istediğiniz ilin plaka kodunu giriniz :");
            int ilPLakaKodu = Convert.ToInt32(Console.ReadLine());

            switch (ilPLakaKodu)
            {
                case 55:Console.WriteLine("Girdiğiniz plaka kodu samsuna aittir.");
                    break;
                case 34:
                    Console.WriteLine("Girdiğiniz plaka kodu istanbula aittir");
                    break;
                case 27:
                    Console.WriteLine("Girdiğiniz plaka kodu gaziantepe aittir");
                    break;
                case 53:
                    Console.WriteLine("Girdiğiniz plaka kodu rizeye aittir.");
                    break;
                default:
                    Console.WriteLine("Tanımlanmamış bir plaka kodu girdiniz");
                    break ;
            }
            Console.Read();
        }
    }
}
