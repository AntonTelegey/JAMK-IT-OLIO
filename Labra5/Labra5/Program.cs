using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JAMK.IT;

namespace Labra5
{
    public class Rengas
    {
        public string Merkki { get; set; }
        public string Tyyppi { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Lab05T01();
        }
        static void Lab05T01()
        {
            //Programmed and tested by Anton Telegey 7.2.17
            //Testataan Tyre ja Vehicle luokkia
            //Luodaan ensimmäinen auto
            Vehicle auto = new JAMK.IT.Vehicle();
            auto.Brand = "BMW";
            auto.Model = "320";
            //ostetaan perit renkaat
            Tyre rinkula = new Tyre();
            rinkula.Branch = "Hankook";
            rinkula.Size = "205/55/R15";
            //laitetaan bemariin takkse renkaat
            auto.AddTyre(rinkula);
            auto.AddTyre(rinkula);

            //naytetään auton tiedot
            Console.WriteLine("Autossasi {0} on seuraavat tiedot: {1}", auto.Brand, auto.ToString());
        }
    }
}
