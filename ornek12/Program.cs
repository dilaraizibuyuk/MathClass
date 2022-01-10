using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ornek12
{
    class Program
    {
        static void Main(string[] args)
        {
            double girilensayi = 919.51;
            double yuvarlama = Math.Round(girilensayi);
            Console.WriteLine("Sayının yuvarlanmış hali:" + yuvarlama);
            Console.ReadLine();
        }
    }
}
