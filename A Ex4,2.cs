using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht2
{
     class Teht2
    {
         static void Main(string[] args)
        {
            Console.WriteLine("Kerro ikäsi");
            int ika = Convert.ToInt32(Console.ReadLine());
            if (ika >= 18 || ika <= 20)
            {
                Console.WriteLine("Onko papereita kyllä/Ei?");
                string vas = Console.ReadLine();

                if (vas == "Kyllä")
                {
                    Console.WriteLine("Tervetuloa ravintolaan");
                }

                else
                {
                    Console.WriteLine("Hyvä yritys!");
                }
            }

            else if (ika < 18)
            {
                Console.WriteLine("Mene kotiin kasvamaan!");
            }

            else
            {
                Console.WriteLine("Tervetuloa ravintolaan");
            }
        }
    }
}
