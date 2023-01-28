using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3
{
    internal class Teht1
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i < 1001)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }
        }
    }
}

//Kirjoita ohjelma, joka tulostaa kolmella jaolliset luvut väliltä 1..1000. Käytä whilesilmukkaa.