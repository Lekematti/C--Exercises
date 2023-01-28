using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht14
{
    internal class Teht14
    {
        static void Main(string[] args)
        {
            
            var num = new string[10];
            
            for (var i = 0; i < num.Length; i++)
            {
                Console.Write("Anna kymmen lukua: ");
                num[i] = Console.ReadLine();
            }
            Console.WriteLine("Luvut käännetty:");
            Array.Reverse(num);
            foreach (var numerot in num)
                Console.WriteLine(numerot);
        }
    }
}
/*Kirjoita ohjelma, joka kysyy käyttäjältä kymmenen lukua ja tallettaa ne taulukkoon.
Tämän jälkeen ohjelma tulostaa luvut päinvastaisessa järjestyksessä.
Käytä forsilmukkaa ja taulukkoa.*/
