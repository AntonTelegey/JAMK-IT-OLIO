using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labra6_3
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
            Lab06T03();
        }
        static void Lab06T03()
        {
            //Programmed and tested by Anton Telegey 20.2.17
            Korttipakka korttipakka = new Korttipakka();
            int numero = 1;

            for (int i=0; i < 13;i++){
                Kortti kortti = new Kortti();
                kortti.Arvo = 2+i;
                kortti.Maa = "Hertta";
                kortti.numero = numero;
                numero++;
                korttipakka.AddCardToList(kortti);
                
            }
            for (int i = 0; i < 13; i++)
            {
                Kortti kortti = new Kortti();
                kortti.Arvo = 2 + i;
                kortti.Maa = "Ruutu";
                kortti.numero = numero;
                numero++;
                korttipakka.AddCardToList(kortti);
                
            }

            for (int i = 0; i < 13; i++)
            {
                Kortti kortti = new Kortti();
                kortti.Arvo = 2 + i;
                kortti.Maa = "Risti";
                kortti.numero = numero;
                numero++;
                korttipakka.AddCardToList(kortti);
                
            }
            for (int i = 0; i < 13; i++)
            {
                Kortti kortti = new Kortti();
                kortti.Arvo = 2 + i;
                kortti.Maa = "Pata";
                kortti.numero = numero;
                numero++;
                korttipakka.AddCardToList(kortti);
                
            }

            Console.WriteLine(korttipakka.ToString());
        }
    }
}
