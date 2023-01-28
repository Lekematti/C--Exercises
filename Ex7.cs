using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht7
{
    internal class Teht7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna luku");
            int luku = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Anna luku");
            int luku2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Anna luku");
            int luku3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Math.Max(Math.Max(luku, luku2), luku3));
        }
    }
}
