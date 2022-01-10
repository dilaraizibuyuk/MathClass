using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ornek3
{
    class Program
    {
        static void Main(string[] args)
        {
            double GirilenSayi = 60;
            double sayi_logaritma = Math.Log10(GirilenSayi);
            Console.WriteLine("60 sayısının log10 hali:"+sayi_logaritma);
            Console.ReadLine();
        }
    }
}
