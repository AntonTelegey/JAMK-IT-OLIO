using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labra6
{
    class Person
    {
        //Properties
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string SocialSecurityNumber { get; set; }
        
        //Methods
        public override string ToString()
        {
            return Firstname + " " + Lastname + " " + SocialSecurityNumber;

        }
    }
    class Persons
    {
        //members=jäsenmuuttujat
        private List<Person> persons;
        //Constructor
        public Persons()
        {
            persons = new List<Person>();

        }
        //methods
        public void Add(Person person)
        {
            persons.Add(person);

        }
        public Person Get(int index)
        {
            //Count eli montako oliota on listassa
            if (index < persons.Count)
            {
                //Listasta palautetaan haluttu alkio ElementAt 
                return persons.ElementAt(index);

            }
            else
                return null;
        }
        public Person Find(string socialcecuritynumber)
        {
            foreach (Person p in persons)
            {
                if (p.SocialSecurityNumber.Equals(socialcecuritynumber))
                {
                    return p;
                }
            }
            return null;
        }
        public void ShowPersons()
        {
            foreach (Person p in persons)
            {
                Console.WriteLine(p.ToString());
            }
        }
    }
}
