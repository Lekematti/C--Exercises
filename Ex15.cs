using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht15
{
    internal class Teht15
    {
        static void Main(string[] args)
        {
            Console.Write("Kuinka monta tähteä (*) : ");
            int num = Convert.ToInt32(Console.ReadLine());
            var nim = new string[num];

            for (var i = 0; i < nim.Length; i++)
            {
                nim[i] = "*";
            }
            Console.WriteLine(num + " tähteä:");

            foreach (var tahti in nim)
                Console.Write(tahti);
                Console.WriteLine();
        }
    }
}
/*Kysy käyttäjältä kuinka monta tähteä (*) tulostetaan. Tämän jälkeen ohjelma
tulostaa tämänmittaisen tähtirivin, esim. 7 tähteä:
********
Käytä for-silmukkaa.
 */
