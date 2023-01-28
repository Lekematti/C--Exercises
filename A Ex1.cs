using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht1
{
    internal class teht1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna nelikulmion molempien sivujen pituudet");
            int luku = Convert.ToInt32(Console.ReadLine());
            int luku2 = Convert.ToInt32(Console.ReadLine());
            int tulos = luku * luku2;
            Console.WriteLine(tulos);
        }
    }
}
