using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaktoriyelHesabı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Faktöriyel hesaplanacak sayıyı giriniz :");
            int sayi=Convert.ToInt32(Console.ReadLine());

            int faktoriyel = 1;
            for(int i=sayi;i>1;i--)
            {
                faktoriyel *= i;
            }
            Console.WriteLine(sayi+" "+"'nin faktöriyeli "+faktoriyel);
            Console.Read();
        }   
    }
}
