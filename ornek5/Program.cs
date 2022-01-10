using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ornek5
{
    class Program
    {
        static void Main(string[] args)
        {
            double GirilenSayi = 58.6598;
            double sayi = Math.Truncate(GirilenSayi);
            Console.WriteLine("Sayı küsüratı alınmış hali:" + sayi);
            Console.ReadLine();
        }
    }
}
