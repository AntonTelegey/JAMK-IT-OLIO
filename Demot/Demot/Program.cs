using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demot
{
    class Ikkuna
    {
        //Propeties - Ominaisuudet
        public float Leveys { get; set; }
        public float Korkeus { get; set; }
        public float Pintaala {
            get { return Leveys * Korkeus; }
        }
        public float Piiri {
            get { return 2 * (Leveys + Korkeus); }
        }
        // Constructors = konstruktorit
        public Ikkuna()
        {
            //Tämä on ns. oletuskonstruktori
        }
        public Ikkuna(float leveys, float korkeus)
        {
            Korkeus = korkeus;
            Leveys = leveys;

        }
        // methods = metodit
        public float LaskePintaala()
        {
            return Leveys * Korkeus;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            OOIkkunademo();
        }
        static void OOIkkunademo()
        {
            //Ohjelma laskee ikkunan pintaalan ja piirin.
            float Leveys = 0;
            float Korkeus = 0;
            float Ala, Piiri = 0;
            //Kysytään käyttäjältä mitat
            Console.WriteLine("Lasken ikkunan pintaalan ja piirin, syötä ikkunan leveys mm. ");
            Leveys = float.Parse(Console.ReadLine());
            Console.WriteLine("Anna korkeus millimetreinä: ");
            Korkeus = float.Parse(Console.ReadLine());
            //Lasketaan pintaala ja piiri.
            Ala = Leveys * Korkeus;
            Piiri = 2 * (Leveys + Korkeus);
            //Console.WriteLine("Ikkunan pintaala on: " + Ala);
            //Console.WriteLine("Ikkunan piiri on: " + Piiri);
            // Toinen vaihtoehto ilmoittaa tiedot:
            //Console.WriteLine("Ikkunan ala {0} ja piiri {1}", Ala, Piiri);

            //sama homma olion avulla:
            Ikkuna ikkuna = new Demot.Ikkuna();
            ikkuna.Leveys = Leveys;
            ikkuna.Korkeus = Korkeus;
            //Ala = ikkuna.LaskePintaala();

            Console.WriteLine("Olion avulla laskettu ikkunan ala {0} ja piiri {1}", ikkuna.Pintaala, ikkuna.Piiri);

            // kokeilaan puolta pienemmällä ikkunalla toista konstruktoria
            Ikkuna ikkuna2 = new Demot.Ikkuna(Leveys/2, Korkeus/2);
            Console.WriteLine("Olioikkunan2 ala {0} ja piiri {1}", ikkuna2.Pintaala, ikkuna2.Piiri);
        }
    }
}
