using System;

namespace Addieren
{
    class Program
    {
        static void Main(string[] args)
        {
            // Einlesen der Werte
            Console.WriteLine("Bitte geben Sie die erste Zahl ein:");
            string input1 = Console.ReadLine();

            Console.WriteLine("Bitte geben Sie die zweite Zahl ein:");
            string input2 = Console.ReadLine();


            // Addieren
            double ergebnis = Convert.ToDouble(input1) + Convert.ToDouble(input2);


            // Ausgabe
            Console.WriteLine(string.Format(
                "Die Addition von {0} und {1} ergibt {2}"
                ,input1,input2, 
                ergebnis.ToString()));
        }
    }
}
