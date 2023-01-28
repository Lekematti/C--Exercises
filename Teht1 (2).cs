using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht1
{
    internal class Teht1
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
        }
        static void Main(string[] args)
        {
            Ihminen A = new Ihminen();
            A.asetaTiedot("A.B",27);
            A.tulostaTiedot();
        }
    }
}
/*Laadi luokka Ihminen, jolla on jäsenmuuttujina nimi ja ika. Jäsenfunktiot ovat
”settereitä” ja ”gettereitä” jäsenmuuttujien arvojen asettamiseen ja palauttamiseen:
set_nimi // asettaa ihmisen nimen
set_ika // asettaa ihmisen iän
get_nimi // palauttaa ihmisen nimen
get_ika // palauttaa ihmisen iän
Noudata kapselointiperiaatetta, eli tee jäsenmuuttujista yksityisiä ja em.
jäsenfunktioista julkisia.
Tee pääohjelma, joka luo ihmis-olion, ja asettaa sille settereiden avulla nimen ja
iän. Tämän jälkeen pääohjelma hakee gettereiden avulla nimen ja iän ja tulostaa ne
ruudulle.*/