using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht3
{
    internal class Teht3
    {
        static void Main(string[] args)
        {
            int i, luku, sum = 0;
            double avg;

            Console.Write("Anna kymmen kokonaislukua, ohjelma kertoo summan ja keskiarvon:\n");
          
            Console.WriteLine("Anna kymmenen lukua");

            for (i = 1; i <= 10; i++)
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
//Kirjoita ohjelma, joka kysyy käyttäjältä kymmenen kokonaislukua. Lopuksi ohjelma
//tulostaa lukujen summan ja keskiarvon. Käytä for-silmukkaa.