using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labra6
{
    class Program
    {
        static void TestPersonClass()
        {
            //Luodaan ns. henkilorekisteri
            //Kokoelmaluokka
            Persons myFriends = new Persons();

            //Luodaan muutama kaveri olio
            Person friend1 = new Person();
            friend1.Firstname = "Kirsi";
            friend1.Lastname = "Kernel";
            friend1.SocialSecurityNumber = "121212-123A";

            //Lyhyempi tapa luoda olio ominaisuuksineen
            Person friend2 = new Person { Firstname = "Jack", Lastname = "Russel", SocialSecurityNumber = "121212-121B" };
            Person friend3 = new Person { Firstname = "Anton", Lastname = "Test", SocialSecurityNumber = "123657-653C" };
            Person friend4 = new Person { Firstname = "Teppo", Lastname = "Testaaja", SocialSecurityNumber = "010101-0010" };

            //Lisätään kaverit yksi kerrallaan kaverirekisteriin
            //Add metodilla
            myFriends.Add(friend1);
            myFriends.Add(friend2);
            myFriends.Add(friend3);
            myFriends.Add(friend4);

            //Näytetään rekisteri
            Console.WriteLine("**** Kaverirekisteri ****");
            myFriends.ShowPersons();

            //Testataan kaverin hakua
            Console.WriteLine("Anna kaverinumero: ");
            string retval = Console.ReadLine();

            //Tarkistetaan että syöte on numero
            int i = 0;
            if (int.TryParse(retval, out i))
            {

                Person searchedFriend = myFriends.Get(i);
                //Person searchedFriend = myFriends.Get(int.Parse(retval));

                //Jos Get metodi palauttaqa null arvo jos kaveria ei löydy
                if (searchedFriend != null)
                {
                    Console.WriteLine(string.Format("Loytyi ystava nimella {0}", searchedFriend.ToString()));
                }
                else
                {
                    Console.WriteLine("Ei löytynyt kaveria");
                }
            } else
            {
                Console.WriteLine("Syötteesi ei kelpa.");
            }
            //Testataan kaveri hakua HETUlla
            Console.WriteLine("Anna kaverisi HETU: ");
            retval = Console.ReadLine();
            Person FindFriend = myFriends.Find(retval);
            if (FindFriend != null)
            {
                Console.WriteLine(string.Format("Löytyi kaveri {0}", FindFriend.ToString()));
            
            }
            else
            {
                Console.WriteLine(string.Format("Annetulla {0} HETUlla ei löytynyt kaveria.", retval));
            }
        }

        static void Main(String[] args)
        {
            TestPersonClass();
        }
    }
}
