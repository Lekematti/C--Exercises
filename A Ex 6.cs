using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht6
{
    internal class Teht6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ensimmäisenä vuotena saamasi opintopistemäärä");
            int op = Convert.ToInt32(Console.ReadLine());
            if (op <= 44)
            {
                Console.WriteLine("KELA ja opet ei tykkää");
            }
            else if (op < 55)
            {
                Console.WriteLine("Opet ei tykkää");
            }
            else if (op >= 55)
            {
                Console.WriteLine("Onnittelut onnistuneesta ensimmäisestä opiskeluvuodesta! :)");
            }
        }
    }
}
