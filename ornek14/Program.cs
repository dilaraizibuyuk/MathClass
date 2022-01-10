using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ornek14
{
    class Program
    {
        static void Main(string[] args)
        {
            double GirilenSayi = 58;
            double sayi = Math.Cos(GirilenSayi);
            Console.WriteLine("Sayının kosinüsü:" + sayi);
            Console.ReadLine();
        }
    }
}
