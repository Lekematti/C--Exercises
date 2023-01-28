
   abstract class Ihminen
    {
        private string set_nimi;
        private int set_ika;
        public abstract void Tervehdi();

        public Ihminen(string nimi, int ika)
        {
            set_nimi = nimi;
            set_ika = ika;
        }
        ~Ihminen()
        {
            Console.WriteLine("Goodbye, ote lipee");
        }
        public string getNimi()
        {
            return set_nimi;
        }
        public int getIka()
        { 
            return set_ika; 
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
    }
    class Suomalainen : Ihminen
    {
        private double _sisu;
        public Suomalainen(string nimi, int ika, double sisu) :
            base(nimi, ika)
        {
            _sisu = sisu;
        }
        public double getSisu()
        {
            return _sisu;
        }
        public override void Tervehdi()
        {
            Console.WriteLine("Hei, olen " + getNimi() + " ja olen " + getIka() + " vuotta vanha. Ja sisuni on  " + _sisu);
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
        public override void Tervehdi()
        {
            Console.WriteLine("Hej, jag heter " + getNimi() + " och jag är " + getIka() + " år gammal. Min lycka är " + _onni);
        }
    }
    internal class Teht5
    {
        static void Main(string[] args)
        {
            Ihminen joku;
            joku = new Suomalainen("Pentti", 50, 0.5);
            joku.Tervehdi();
            Console.WriteLine("-------------------------");
            joku = new Ruotsalainen("Tom", 25, 1000);
            joku.Tervehdi();
            Console.WriteLine("-------------------------");
        }
    }
/*Määrittele yliluokan (Ihminen) tervehdi-funktio abstraktiksi. Ylikirjoita Suomalaisen
ja Ruotsalaisen tervehdi-funktiot niin, että ne tulostavat tervehdyksen joko
suomeksi tai ruotsiksi. Vinkki: avainsanat abstract ja override.
Testaa tervehdi-funktiota pääohjelmassa alla olevalla tavalla. Miten polymorfismi
ilmenee?
Ihminen joku;
joku = new Suomalainen(”Pentti”, 50, 0.5);
joku.tervehdi();
joku = new Ruotsalainen(”Tom”, 25, 1000);
joku.tervehdi();*/
