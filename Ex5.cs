using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht5
{
    internal class Teht5
    {
        static void Main(string[] args)
        {
            MyMethod();
        }
        static void MyMethod()
        {
            Console.WriteLine("Anna luku");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("Number is even");
            }
            else
            {
                Console.WriteLine("Number is not even");
            }
        }
    }
}
