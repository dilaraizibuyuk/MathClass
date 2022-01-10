using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClass
{
    class Program
    {
        static void Main(string[] args)
        {
            double sayi = 9.3;
            double yuvarla = Math.Ceiling(sayi);
            Console.WriteLine("Sonuç:"+yuvarla);
            Console.ReadKey();
        }
    }
}
