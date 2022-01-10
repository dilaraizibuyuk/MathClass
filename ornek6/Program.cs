using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ornek6
{
    class Program
    {
        static void Main(string[] args)
        {
            double GirilenSayi = 24;
            double sayi = Math.Atan(GirilenSayi);//arctan
            Console.WriteLine("Ekran çıktısı:" + sayi);
            Console.ReadLine();
        }
    }
}
