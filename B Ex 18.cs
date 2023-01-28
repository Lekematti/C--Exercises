using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht18
{
    class Ihminen
    {
        private string set_nimi;
        private int set_ika;

        public Ihminen(string set_nimi,  int set_ika)
        {
            asetaTiedot(set_nimi, set_ika);
        }
        ~Ihminen()
        {
            Console.WriteLine("Goodbye, ote lipee");
        }
        public void asetaTiedot(string get_nimi, int get_ika)
        {
            set_nimi = get_nimi;
            set_ika = get_ika;
        }
        public void tulostaTiedot()
        {
            Console.WriteLine(set_nimi);
            Console.WriteLine(set_ika);
        }
        public void vanhene()
        {
            set_ika = set_ika + 1;
        }
        public void tervehdi()
        {
            Console.WriteLine("Hei, olen " + set_nimi + " ja olen " + set_ika + " vuotta vanha");
        }

        static void Main(string[] args)
        {
            Ihminen A = new Ihminen("A.B", 27);
            A.vanhene();
            A.tervehdi();

        }
    }
}
/*Lisää luokkaan konstruktori, jonka avulla olio voidaan luoda siten, että sen nimi ja
ikä määritellään luonnin yhteydessä.(ei tarvitse tehdä. Lisää myös destruktori, joka tulostaa
”Goodbye, ote lipee” kun olio on tuhoutumassa.
Testaa.)*/
