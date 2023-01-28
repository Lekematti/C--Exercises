using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht2
{
    internal class Teht2
    {
        class Ihminen
        {
            private string set_nimi;
            private int set_ika;
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
                Ihminen A = new Ihminen();
                A.asetaTiedot("A.B", 27);
                A.vanhene();
                A.tervehdi();

            }
        }
    }
}
/*Lisää luokkaan jäsenfunktio tervehdi, joka tulostaa ruudulle tervehdyksen tyyliin
”Hei, olen Arto ja olen 50 vuotta vanha”. Lisää myös jäsenfunktio vanhene, joka
kasvattaa ikää yhdellä.
Testaa pääohjelmassa.*/