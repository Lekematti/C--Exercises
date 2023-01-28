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
            Console.Write("Kuinka monta kaveria: ");
            int num = Convert.ToInt32(Console.ReadLine());
            var nim = new string[num];

            for (var i = 0; i < nim.Length; i++)
            {
                Console.Write("Kaverin nimi: ");
                nim[i] = Console.ReadLine();
            }
            Console.WriteLine("Kaverisi ovat:");

            foreach (var kaveri in nim)
                Console.WriteLine(kaveri);
        }
    }
}
//Kysy käyttäjältä kuinka monta ystävää hänellä on. Kysy kaikkien ystävien nimet ja
//talleta ne taulukkoon. Lopuksi tulosta ystävälista taulukosta. Käytä for-silmukkaa
//ja taulukkoa.