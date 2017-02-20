using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labra6_3
{
    public class Korttipakka
    {
        //Properties

        //tyypitetty list aon dynaaminen
        public List<Kortti> Kortit { get; }
        //Constructors
        public Korttipakka()
        {

            Kortit = new List<Kortti>();
        }
        //Methods
        public void AddCardToList(Kortti Kortti)
        {
            Kortit.Add(Kortti);
        }
        public override string ToString()
        {
            string retval = "Korttipakka sisaltaa seuraava kortit:";
            foreach (Kortti kortti in Kortit)
            {
                if (kortti != null)
                {
                    retval += "\n" + kortti.ToString();
                }
            }
            return retval;
        }
    }
    public class Kortti
    {
        public int Arvo { get; set; }
        public string Maa { get; set; }
        public int numero { get; set; }
        public override string ToString()
        {
            return String.Format("{0}, {1}, {2}", numero, Arvo, Maa);

        }
    }
}
