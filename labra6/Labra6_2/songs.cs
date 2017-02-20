using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labra6_2
{
    public class Cd
    {
        //Properties
        public string Name { get; set; }
        public string Artist { get; set; }
        //tyypitetty list aon dynaaminen
        public List<Song> Songs { get; }
        //Constructors
        public Cd()
        {
            
            Songs = new List<Song>();
        }
        //Methods
        public void AddSongToList(Song song)
        {
            Songs.Add(song);
        }
        public override string ToString()
        {
            string retval = "CD data:\n Name: " + Name + "\n Artist: " + Artist + "\n Songs: ";
            foreach (Song song in Songs)
            {
                if (song != null)
                {
                    retval += "\n" + song.ToString();
                }
            }
           
            return retval;
        }
    }
    public class Song
    {
        public string Name { get; set; }
        public string Time { get; set; }
        public override string ToString()
        {
            //return "Valmistaja: " + Branch + "koko: " + Size;
            return String.Format("{0}, {1}", Name, Time);
            
        }
    }
}
