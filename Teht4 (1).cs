using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht4
{
    internal class Teht4
    {
        static void Main(string[] args)
        {
            int i, luku,luku1, sum = 0;
            double avg;

            Console.Write("ohjelma kertoo summan ja keskiarvon \n");

            Console.WriteLine("Kuinka monta lukua");
            luku1 = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= luku1; i++)
            {
                Console.Write("Number-{0} : ", i);

                luku = Convert.ToInt32(Console.ReadLine());

                sum += luku;
            }
            avg = sum / 10.0;

            Console.Write("summa : {0}\nkeskiarvo : {1}\n", sum, avg);
        }
    }
}
//Muuten sama kuin tehtävä 3, mutta ohjelma kysyy ensimmäisenä kuinka monta
//lukua käyttäjä haluaa syöttää