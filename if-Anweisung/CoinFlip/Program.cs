using System;

namespace CoinFlip
{
    class Program
    {
        static void Main(string[] args)
        {
            // Objekt vom Typ Radnom erstellt
            Random zufall = new Random();

            // Zufällig 0 = Kopf oder 1 = Zahl
            int z = zufall.Next(0, 2);

            // Ausgabe
            if (z == 0)
            {
                Console.WriteLine("Kopf");
            }
            else if (z == 1)
            {
                Console.WriteLine("Zahl");
            }

            Console.Read();
        }
    }
}
