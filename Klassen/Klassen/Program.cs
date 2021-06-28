using System;
using System.Collections.Generic;

namespace Klassen
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> personen = new List<Person>();
            // erstellt neue Instanz von Klasse Person
            Person p1 = new Person("Benedikt", "Neuhold");

            personen.Add(p1);

            Person p2 = new Person();
            p2.Vorname = "Hanna";
            p2.Nachname = "Lustig";

            p1.Sprechen("Hallo");
            p2.Sprechen("Hello");

            personen.Add(p2);

            foreach(Person p in personen)
            {
                Console.WriteLine(p.ToString());
            }
            
        }
    }
}
