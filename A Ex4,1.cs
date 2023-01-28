using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    internal class Teht1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kerro ikäsi");
            int ika = Convert.ToInt32(Console.ReadLine());
            if (ika >= 18)
            {
                Console.WriteLine("Tervetuloa ravintolaan");
            }
            else
            {
                Console.WriteLine("Mene kotiin kasvamaan!");
            }
        }
    }
}
