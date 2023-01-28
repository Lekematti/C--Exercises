using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht2
{
    internal class teht2
    {
        public const double PI = 3.141592;
        static void Main(string[] args)
        {
            Console.WriteLine("Anna ympyrän säde");
            int sade = Convert.ToInt32(Console.ReadLine());
            double tulos = 2 * PI * sade;
            Console.WriteLine(tulos);
        }
    }
}
