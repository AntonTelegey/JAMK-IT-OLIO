using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labra6_2
{
    //public class Rengas
    //{
    //    public string Merkki { get; set; }
    //    public string Tyyppi { get; set; }
    //}
    class Program
    {
        static void Main(string[] args)
        {
            Lab06T02();
        }
        static void Lab06T02()
        {
            //Programmed and tested by Anton Telegey 20.2.17
            Cd levy = new Cd();
            levy.Name = "nimi1";
            levy.Artist = "artisti1";
            Song kappale = new Song();
            kappale.Name = "kappale1";
            kappale.Time = "3.15";
            levy.AddSongToList(kappale);
            
            Console.WriteLine(levy.ToString());
        }
    }
}
