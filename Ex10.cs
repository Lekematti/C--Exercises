using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht2
{
    internal class Teht2
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            int number = rand.Next(0, 100);
            int arv = 0;
            Console.WriteLine("Arvaa luku 1-100");
       
            while (arv != number)
            {
                arv = Convert.ToInt32(Console.ReadLine());

                if (arv < number)
                {
                    Console.WriteLine("Liian pieni");
                }
                else if (arv > number)
                {
                    Console.WriteLine("Liian suuri");
                }
                else if (arv == number)
                {
                    Console.WriteLine("oikein " + number);
                }
            }
        }
    }
}


//Kirjoita peli, jossa tietokone arpoo kokonaisluvun väliltä 1..100. Kone arvuuttelee
//lukua pelaajalta siihen asti, kunnes tämä arvaa oikein. Kunkin arvauksen jälkeen
//ohjelma tulostaa tekstin ”Liian suuri arvaus.”, ”Liian pieni arvaus” tai ”Oikein”.
//Huomaa, että tietokone ei saa vaihtaa lukuaan arvauskertojen välissä. Käytä
//while-silmukkaa. Satunnaisluvun arpomiseen saat ohjeita tunnilla.
