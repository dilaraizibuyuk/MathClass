using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ornek2
{
    class Program
    {
        static void Main(string[] args)
        {
            double sayi = -9;
            double sayi2 = 4;
            double sayi3 = 0;
            double ilkdeger = Math.Sign(sayi);
            double ikincideger = Math.Sign(sayi2);
            double sondeger = Math.Sign(sayi3);
            Console.WriteLine("Sonuç 1:"+ilkdeger);
            Console.WriteLine("Sonuç 2:" + ikincideger);
            Console.WriteLine("Sonuç 3:" + sondeger);

            Console.ReadKey();
        }
    }
}
