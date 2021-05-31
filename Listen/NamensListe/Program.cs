using System;
using System.Collections.Generic;

namespace NamensListe
{
    class Program
    {
        static void Main(string[] args)
        {
            // Leere Liste erstellen
            List<string> namen = new List<string>();

            // Hinzufügen zur Liste
            namen.Add("Benedikt");
            namen.Add("Hans");
            namen.Add("Benedikt");

            // Zählen wie viele Elemente meine Liste enthält
            Console.WriteLine("Die Liste enthält " + namen.Count + " Elemente");

            // Löschen eines Elements
            namen.Remove("Benedikt"); // Remove löscht das zuerst vorkommende Element in der Liste.
            namen.RemoveAt(0);

            Console.WriteLine("Die Liste enthält " + namen.Count + " Elemente");

            // Alle Elemente einer Liste löschen
            namen.Clear();

            // Eingabe von 5 Namen
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Bitte geben sie einen Namen ein:");
                string name = Console.ReadLine();
                namen.Add(name); // Füge den Inhalt von name zur Liste hinzu
            }

            // gehe alle Elemente der Liste durch
            foreach(string n in namen)
            {
                Console.WriteLine(n);
            }
        }
    }
}
