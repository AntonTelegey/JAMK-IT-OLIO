/* Anton Telegey kotitehtavat
* tehty 17.1.17
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace olio1
{
    class Kayttaja
    {
        public string Nimi { get; set; }
    }
    //luodaan Henkilo niminen luokka johon kuuluu nimi ja ika kentät.
    class Henkilo
    {
        //get - lukea, set - asettaa.
        public string Nimi { get; set; }
        public int Ika { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {

            valikko();
        }
        static void valikko()
        {
            Console.Clear();
            int valinta = -1;
            while (valinta != 0)
            {
                int tehtavia = 20;
                int muita = 4;
                Console.WriteLine("Valikko:");
                for (int i=1; i <= tehtavia; i++) {
                    Console.WriteLine(i + " = Tehtava " + i);
                }
                Console.WriteLine(tehtavia + 1 + " = SayHello() ");
                Console.WriteLine(tehtavia + 2 + " = AksAge() ");
                Console.WriteLine(tehtavia + 3 + " = kayttajat() ");
                Console.WriteLine(tehtavia + 4 + " = arvonta() ");
                Console.WriteLine("0 = Lopeta ");
                Console.WriteLine("Valitse ohjelma: ");
                string syote = Console.ReadLine();
                valinta = int.Parse(syote);
                if (valinta == 1) { tehtava1(); }
                else if (valinta == 2) { tehtava2(); }
                else if (valinta == 3) { tehtava3(); }
                else if (valinta == 4) { tehtava4(); }
                else if (valinta == 5) { tehtava5(); }
                else if (valinta == 6) { tehtava6(); }
                else if (valinta == 7) { tehtava7(); }
                else if (valinta == 8) { tehtava8(); }
                else if (valinta == 9) { tehtava9(); }
                else if (valinta == 10) { tehtava10(); }
                else if (valinta == 11) { tehtava11(); }
                else if (valinta == 12) { tehtava12(); }
                else if (valinta == 13) { tehtava13(); }
                else if (valinta == 14) { tehtava14(); }
                else if (valinta == 15) { tehtava15(); }
                else if (valinta == 16) { tehtava16(); }
                else if (valinta == 17) { tehtava17(); }
                else if (valinta == 18) { tehtava18(); }
                else if (valinta == 19) { tehtava19(); }
                else if (valinta == 20) { tehtava20(); }
                else if (valinta == tehtavia + 1)
                {
                    SayHello();
                }
                else if (valinta == tehtavia + 2)
                {
                    AksAge();
                }
                else if (valinta == tehtavia + 3)
                {
                    kayttajat();
                }
                else if (valinta == tehtavia + 4)
                {
                    arvonta();
                }
                else
                {
                    if (valinta > muita + tehtavia && valinta < 0) { valikko(); }
                }
                
            }
        }
        static void SayHello()
        {
            Console.Clear();
            Henkilo immeinen = new Henkilo();
            immeinen.Nimi = "Ville Petteri";
            immeinen.Ika = 25;
            //naytetaan olion tiedot loppukayttajalle
            Console.WriteLine("Hello " + immeinen.Nimi + ".");
            Console.WriteLine("Olet " + immeinen.Ika + " vuotias.");
            //talla saa konsolin jaamaan nakyviin
            Console.ReadLine();
            valikko();
        }
        static void AksAge()
        {
            Console.Clear();
            Console.WriteLine("Syota syntymavuosi: ");
            string syote = Console.ReadLine();
            int vuosi = int.Parse(syote);
            Console.WriteLine("Syota syntymakuukausi: ");
            string syote2 = Console.ReadLine();
            int kk = int.Parse(syote2);
            Console.WriteLine("Syota syntymapaiva: ");
            string syote3 = Console.ReadLine();
            //Muutetaan syote int muotoon string muodosta.
            int pv = int.Parse(syote3);
            int kuluvavuosi = DateTime.Today.Year;
            int kuluvakuukausi = DateTime.Today.Month;
            int kuluvapaiva = DateTime.Today.Day;
            int ika;
            ika = kuluvavuosi - vuosi;
            if (kk == kuluvakuukausi)
            {
                if (pv >= kuluvapaiva)
                {
                    ika--;
                }
            }
            Console.WriteLine("Olet " + ika + " vuotias.");
            Console.ReadLine();
            valikko();
        }
        static void kayttajat()
        {
            Console.Clear();

            string[] array = new string[5];
            Console.WriteLine("Anna käyttäjien etunimet:");
            for (int i = 0; i < 5; i++)
            {
                array[i] = Convert.ToString(Console.ReadLine());
            }
            Console.WriteLine("Annoit nimet: ");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine("\nNimet aakkosjärjetyksessä: ");
            Array.Sort(array);
            foreach (string k in array)
            {
                Console.Write(k + " ");
            }
            Console.ReadLine();
            valikko();
        }
        static void arvonta()
        {
            Console.Clear();
            Console.Write("Anna arvottavien rivien määrä > ");
            string syote = Console.ReadLine();
            int rivit = int.Parse(syote);

            Random rand = new Random();

            for (int i = 1; i < rivit + 2; i++)
            {
                int[] lotto = new int[7];
                Console.Write("Rivi " + i + ": ");

                for (int n = 0; n < 7;)
                {
                    int check = rand.Next(1, 41);
                    while (!(lotto.Contains(check)))
                    {
                        lotto[n] = check;
                        n++;
                        //Console.Write(check);
                        //if (n < 7) { Console.Write(","); }
                    }
                    //if (n > 6) { Console.WriteLine(""); }
                }
                //for (int b = 0; b < lotto.Length; b++) Console.Write(lotto[b]);

                Array.Sort(lotto);
                for (int b = 0; b < lotto.Length; b++)
                {
                    Console.Write(lotto[b]);
                    if (b < 6) { Console.Write(", "); } else { Console.Write("\n"); }
                }
            }
            Console.ReadLine();
            valikko();
        }
        static void tehtava1()
        {
            Console.Clear();
            int numero;
            Console.WriteLine("Anna luku 1-3 > ");
            string syote = Console.ReadLine();
            numero = int.Parse(syote);
            if (numero == 1)
            {
                Console.WriteLine("Annoit luvun yksi");
            } else if (numero == 2)
            {
                Console.WriteLine("Annoit luvun kaksi");
            } else  if (numero == 3)
            {
                Console.WriteLine("Annoit luvun kolme");
            } else {
                Console.WriteLine("Anna luku 1-3 > ");
            }
            Console.ReadLine();
            valikko();
        }
        static void tehtava2 ()
        {
            Console.Clear();
            int numero;
            Console.WriteLine("Anna pistemäärä 0-12 > ");
            string syote = Console.ReadLine();
            numero = int.Parse(syote);
            if (numero == 0 || numero == 1)
            {
                Console.WriteLine("Koulunumero on 0");
            }
            else if (numero == 2 || numero == 3)
            {
                Console.WriteLine("Koulunumero on 1");
            }
            else if (numero == 4 || numero == 5)
            {
                Console.WriteLine("Koulunumero on 2");
            }
            else if (numero == 6 || numero == 7)
            {
                Console.WriteLine("Koulunumero on 3");
            }
            else if (numero == 8 || numero == 9)
            {
                Console.WriteLine("Koulunumero on 4");
            }
            else if (numero == 10 || numero == 11 || numero == 12)
            {
                Console.WriteLine("Koulunumero on 5");
            }
            else
            {
                Console.WriteLine("Anna pistemäärä 0-12 > ");
            }
            Console.ReadLine();
            valikko();
        }
        static void tehtava3 ()
        {
            Console.Clear();
            int[] array = new int[3];
            Console.WriteLine("Syota 3 numeroa:");
            for (int i = 0; i < 3; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            int size = array.Length;
            int sum = 0;
            int average = 0;
            for (int i = 0; i < size; i++)
            {
                sum += array[i];
            }
            average = sum / size;
            Console.WriteLine("Summa: " + sum);
            Console.WriteLine("Keskiarvo: " + average);
            Console.ReadLine();
            valikko();
        }
        static void tehtava4 ()
        {
            Console.Clear();
            Console.WriteLine("Minka ikainen olet?:");
            string syote = Console.ReadLine();
            int ika = int.Parse(syote);
            if (ika < 18)
            {
                Console.WriteLine("Olet alaikainen.");
            } else if (ika > 17 && ika < 66) {
                Console.WriteLine("Olet aikuinen.");
            } else if (ika > 65)
            {
                Console.WriteLine("Olet seniori.");
            } else
            {
                tehtava4();
            }
            Console.ReadLine();
            valikko();
        }
        static void tehtava5()
        {
            Console.Clear();
            Console.Write("Anna sekunnit > ");
            string syote = Console.ReadLine();
            int sekunnit = int.Parse(syote);

            int tunnit = sekunnit / 3600;
            int minuutit = sekunnit / 60 - tunnit * 60;
            int sek = sekunnit % 60;

            Console.WriteLine("Antamasi sekunttiaika voidaan ilmaista muodossa: " + tunnit + " tunti " + minuutit + " minuutti " + sek + " sekuntti");
            Console.ReadLine();
            valikko();
        }
        static void tehtava6()
        {
            Console.Clear();
            Console.Write("Anna ajokilometrit > ");
            string syote = Console.ReadLine();
            int km = int.Parse(syote);
            Double bensa = km * 0.0702;
            Double menot = bensa * 1.595;

            Console.WriteLine("Bensa kulutus: " + bensa);
            Console.WriteLine("Menot: " + menot + " euroa.");
            Console.ReadLine();
            valikko();
        }
        static void tehtava7()
        {
            Console.Clear();
            Console.Write("Anna vuosiluku > ");
            string syote = Console.ReadLine();
            int vuosi = int.Parse(syote);

            int karkausvuosi = vuosi % 4;

            if (karkausvuosi == 0) {
                if (vuosi % 400 == 0)
                {
                    Console.Write("Vuosiluku: " + vuosi + " on karkausvuosi");
                } else if (vuosi % 100 == 0)
                {
                    Console.Write("Vuosiluku: " + vuosi + " ei ole karkausvuosi");
                }

            } else
            {
                Console.Write("Vuosiluku: " + vuosi + " ei ole karkausvuosi");
            }
            Console.ReadLine();
            valikko();
        }
        static void tehtava8() {
            Console.Clear();
            int[] array = new int[3];
                Console.WriteLine("Syota 3 numeroa: ");
                for (int i = 0; i < 3; i++)
                {
                    array[i] = Convert.ToInt32(Console.ReadLine());
                }
                Array.Sort(array);
                Array.Reverse(array);
                Console.WriteLine("Suurin numero on: " + array[0]);
                Console.ReadLine();
                valikko();
        }
        static void tehtava9() {
            Console.Clear();
            int summa = 0;
            int numero = 1;
                while (numero != 0)
                {
                    Console.WriteLine("Syota numero: (Lopeta 0)");
                    string syote = Console.ReadLine();
                    numero = int.Parse(syote);
                    summa = summa + numero;
                } 
                Console.WriteLine("Lukujen summa on " + summa);
                Console.ReadLine();
                valikko();
        }
        static void tehtava10() {
            Console.Clear();
            int[] taulukko = new int[9] { 1, 2, 33, 44, 55, 68, 77, 96, 100 };
            for (int b = 0; b < taulukko.Length; b++) {
                    Console.Write(taulukko[b]);
                    if (taulukko[b] % 2 == 0 ) { Console.WriteLine("HEP"); }
            }
            Console.ReadLine();
            valikko();
        }
        static void tehtava11 () {
            Console.Clear();
            Console.WriteLine("Syota numero: ");
            string syote = Console.ReadLine();
            int numero = int.Parse(syote);
            for (int i = 0; i <= numero; i++) {
                for (int a = 0; a < i; a++) {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
            valikko();
        }

        static void tehtava12() {
            Console.Clear();
            int lukuja = 5;
            int[] array = new int[lukuja];
            for (int i = 0; i < lukuja; i++)
            {
                Console.WriteLine("Anna luku > ");
                string line = Console.ReadLine();
                int numero;
                bool result = Int32.TryParse(line, out numero);
                array[i] = numero;
            }
            Array.Reverse(array);
            foreach (int k in array)
            {
                Console.Write("Luvut ovat: " + k + ", ");
            }
            Console.ReadLine();
            valikko();
        }
        static void tehtava13() {
            Console.Clear();
            int lukuja = 5;
            int summa = 0;
            int[] array = new int[lukuja];
            int size = array.Length;
            for (int i = 0; i < lukuja; i++)
            {
                Console.WriteLine("Anna pisteet > ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(array);

            for (int i = 0; i < size; i++)
            {
                summa += array[i];
            }
            summa = summa - array[0] - array[4];
            Console.WriteLine("Kokonaispisteet ovat " + summa);
            Console.ReadLine();
            valikko();
        }
        static void tehtava14() {
            Console.Clear();
            int opiskelijoita = 8;
            int arvosana0 = 0;
            int arvosana1 = 0;
            int arvosana2 = 0;
            int arvosana3 = 0;
            int arvosana4 = 0;
            int arvosana5 = 0;

            for (int i = 0; i < opiskelijoita; i++)
            {
                Console.WriteLine("Anna arvosana > ");
                string syote = Console.ReadLine();
                int numero = int.Parse(syote);
                if (numero == 0) {
                    arvosana0 = arvosana0 + 1;
                } else if (numero == 1) {
                    arvosana1 = arvosana1 + 1;
                } else if (numero == 2) {
                    arvosana2 = arvosana2 + 1;
                } else if (numero == 3) {
                    arvosana3 = arvosana3 + 1;
                } else if (numero == 4) {
                    arvosana4 = arvosana4 + 1;
                } else if (numero == 5) {
                    arvosana5 = arvosana5 + 1;
                }
            }
            Console.WriteLine("Arvosanat 1-5:");
            Console.WriteLine("0:");
            for (int i = 0; i < arvosana0; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            Console.Write("1:");
            for (int i = 0; i < arvosana1; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine("2:");
            for (int i = 0; i < arvosana2; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine("3:");
            for (int i = 0; i < arvosana3; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine("4:");
            for (int i = 0; i < arvosana4; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine("5:");
            for (int i = 0; i < arvosana5; i++)
            {
                Console.Write("*");
            }
            Console.ReadLine();
            valikko();
        }
        static void tehtava15() {
            Console.Clear();
            Console.WriteLine("Anna luku > ");
            string syote = Console.ReadLine();
            int numero = int.Parse(syote);
            int puu = numero - 2;
            int jalka = 2;

            for (int i = 0; i < puu; i++)
                {
                    int vali = puu - i;
                    for (int a = 0; a <= vali; a++)
                    {
                        Console.Write(" ");
                    }
                    for (int tahti = 0; tahti <= i * 2; tahti++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
                for (int i = 0; i < jalka; i++)
                {
                    for (int a = 0; a <= puu; a++)
                    {
                        Console.Write(" ");
                    }
                    Console.WriteLine("*");
                }
                Console.ReadLine();
                valikko();
        }
        static void tehtava16() {
            Console.Clear();
            Random rand = new Random();
            int random = rand.Next(1, 101);
            
            int arvauksia = 0;
            int arvottu = 0;

            while(random != arvottu) {
                Console.Clear();
                Console.WriteLine("Arvaa luku > ");
                string syote = Console.ReadLine();
                arvottu = int.Parse(syote);
                arvauksia++;
                if (arvottu > random) {
                    Console.WriteLine("Numero on pienempi ");
                } else if (arvottu < random) {
                    Console.WriteLine("Numero on suurempi ");
                } 
            } 
            Console.WriteLine("Hienoa, arvasit luvun " + arvauksia + " kerralla.");
            Console.ReadLine();
            valikko();
        }
        static void tehtava17() {
            Console.Clear();
            int[] taulukko1 = { 10, 20, 30, 40, 50 };
            int[] taulukko2 = { 5, 15, 25, 35, 45 };
            int[] yhdistettytaulukko = taulukko1.Concat(taulukko2).ToArray();
            Array.Sort(yhdistettytaulukko);
            int size = yhdistettytaulukko.Length;
            Console.WriteLine("Luvut yhdistetyssä taulukossa : ");
            for (int i = 0; i < size; i++)
            {
                Console.Write(yhdistettytaulukko[i] + ",");
            }
            Console.ReadLine();
            valikko();
        }
        static void tehtava18() {
            Console.Clear();
            Console.Write("Kirjoita joku lause : ");
            string lause = Console.ReadLine();
            int pituus = lause.Length;
            int palidromi = 0;

            for (int i = 0; i < pituus / 2; i++)
            {
                if (lause[i] == lause[pituus - i - 1])
                {
                    palidromi = 1;
                }
            }
            if (palidromi == 1)
            {
                Console.WriteLine("Lause on palidromi.");
            }
            else
            {
                Console.WriteLine("Lause ei ole palidromi.");
            }
            Console.ReadLine();
            valikko();
        }
        static void tehtava19() {
            Console.Clear();

            string sana = "OPISKELIJA";
            StringBuilder arvaus = new StringBuilder("__________");
            int arvauskerrat = 0;
            int max = 20;

            do
            {
                Console.WriteLine("Arvaa kirjain ");
                string kirjain = Console.ReadLine().ToUpper();
                arvauskerrat ++;

                for (int i = 0; i < sana.Length; i++)
                {
                    if (sana[i] == kirjain[0]) {
                        arvaus[i] = kirjain[0];
                    }
                }
                Console.WriteLine("Arvatut kirjaimet: " + arvaus);
                Console.WriteLine("Olet arvonnut " + arvauskerrat + " kertaa.");
                Console.WriteLine("Arvaa uudestaan ");
                if (sana == arvaus.ToString())
                {
                    Console.Clear();
                    Console.WriteLine("Onneksi olkoon! Arvasit sanan " + arvauskerrat + " kertaa");
                    Console.WriteLine("Arvattu sana on " + sana);
                }
            } while (arvauskerrat < max && sana.Equals(arvaus.ToString()));

                
            Console.ReadLine();
            valikko();
        }
        static void tehtava20()
        {
            Console.Clear();

            Console.ReadLine();
            valikko();
        }
    }
}
