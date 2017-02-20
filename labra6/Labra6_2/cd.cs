using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labra6
{
    class Cd
    {
        //Properties
        public string Name { get; set; }
        public string Artist { get; set; }
                //Methods
        public override string ToString()
        {
            return Name + " " + Artist;

        }
    }
    class Songs
    {
        //members=jäsenmuuttujat
        private List<Songs> persons;
        //Constructor
        public Songs()
        {
            songs = new List<Songs>();

        }
        //methods
        public void Add(Songs song)
        {
            songs.Add(songs);

        }
        public void ShowSongs()
        {
            foreach (Songs s in songs)
            {
                Console.WriteLine(s.ToString());
            }
        }
    }
}
