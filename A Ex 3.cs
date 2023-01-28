using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht3
{
    internal class teht3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Illallisien kalorimäärä");
            int cal = Convert.ToInt32(Console.ReadLine());
            double joul = 4.1840;
            double tulos = cal * joul;
            Console.WriteLine(cal + " kalorin illallinen on " + tulos + " joulea");
        }
    }
}
