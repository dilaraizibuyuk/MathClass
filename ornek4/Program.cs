using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ornek4
{
    class Program
    {
        static void Main(string[] args)
        {
            double GirilenSayi = 120;
            double sayi_tanjant = Math.Tan(GirilenSayi);
            Console.WriteLine("120 sayısının tanjantı:" + sayi_tanjant);
            Console.ReadLine();

        }
    }
}
