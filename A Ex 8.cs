using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Teht6
{
    internal class Teht6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna arvosana 0-5");
            int arv = Convert.ToInt32(Console.ReadLine());

            switch (arv)
            {
                case 0:
                    Console.WriteLine("hylätty");
                    break;
                case 1:
                    Console.WriteLine("tyydyttävä");
                    break;
                case 2:
                    Console.WriteLine("tyydyttävä");
                    break;
                case 3:
                    Console.WriteLine("hyvä");
                    break;
                case 4:
                    Console.WriteLine("hyvä");
                    break;
                case 5:
                    Console.WriteLine("kiitettävä");
                    break;
            }
        }
    }
}
