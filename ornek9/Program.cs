using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ornek9
{
    class Program
    {
        static void Main(string[] args)
        {
            double sayi;
            Console.WriteLine("Mutlak değeri alınacak sayıyı giriniz:");
            sayi = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Sayının mutlak değeri:"+Math.Abs(sayi));
            Console.ReadLine();
        }
    }
}
