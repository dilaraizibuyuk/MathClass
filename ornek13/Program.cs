using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ornek13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Sayıyı Giriniz:");
            double sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2. Sayıyı Giriniz:");
            double sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sonuç= "+Math.Pow(sayi1,sayi2));
            Console.ReadLine();
        }
    }
}
