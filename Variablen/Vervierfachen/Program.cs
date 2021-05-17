using System; // Import in python

namespace Vervierfachen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte geben Sie eine Zahl ein:");

            // Eingabe
            string eingabe = Console.ReadLine();


            // Deklaration der Variable
            int a;

            // Initialisierung von a
            a = Convert.ToInt32(eingabe);

            // Zahl vervierfachen
            int vierfach = 4 * a;

            //Ausgabe
            Console.WriteLine("Das Ergebnis ist " + vierfach.ToString());
        }
    }
}
