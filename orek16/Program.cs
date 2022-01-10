using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ornek16
{
    class Program
    {
        static void Main(string[] args)
        {
            double sayi;
            Console.WriteLine("Sinüs değeri alınacak sayıyı giriniz:");
            sayi = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Sayının Sinüsü:"+Math.Sin(sayi));
            Console.ReadKey();
        }
    }
}
