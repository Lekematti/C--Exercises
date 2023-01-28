using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht19
{
        class Ihminen
        {
            private string set_nimi;
            private int set_ika;
            public Ihminen(string set_nimi, int set_ika)
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
        }
        class Suomalainen : Ihminen
        {
            private double _sisu;
            public Suomalainen(string nimi, int ika, double sisu):
                base(nimi, ika)
            {
                _sisu = sisu;
            }
            public double getSisu() 
            { 
                return _sisu; 
            }
        }
        class Ruotsalainen : Ihminen
        {
            private double _onni;
            public Ruotsalainen(string nimi, int ika, double onni) :
                base(nimi, ika)
            {
                _onni = onni;
            }
            public double getOnni()
            {
                return _onni;
            } 
        }
    internal class Teht4
    {
        static void Main(string[] args)
        {
            Ihminen A = new Ihminen("A.B", 27);
            A.vanhene();
            A.tervehdi();
            Console.WriteLine("-------------------------");

            Suomalainen B = new Suomalainen("B.C", 24, 98.5);
            B.tervehdi();
            Console.WriteLine("ja sisuni on " + B.getSisu());
            Console.WriteLine("-------------------------");

            Ruotsalainen C = new Ruotsalainen("C.D", 26, 57.3);
            C.tervehdi();
            Console.WriteLine("ja onneni on " + C.getOnni());
            Console.WriteLine("-------------------------");
        }
        
    }
}
/*Määrittele Ihmisen aliluokat Suomalainen ja Ruotsalainen. Suomalaisella on
Ihmisen ominaisuuksien lisäksi jäsenmuuttuja sisu (desimaaliluku). Ruotsalaisella on
lisäominaisuutena jäsenmuuttuja onnekkuus (desimaaliluku). Tee getterit
sisulle/onnekkuudelle.*/
