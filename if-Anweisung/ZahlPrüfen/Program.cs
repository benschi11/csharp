using System;

namespace ZahlPrüfen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bitte geben sie eine beliebige Zahl ein:");

            int input = Convert.ToInt32(Console.ReadLine());

            if (input <= 50)
            {
                Console.WriteLine("Die Zahl ist kleiner oder gleich wie 50");
            }
            else
            {
                Console.WriteLine("Die Zahl ist größer als 50");
            }

        }
    }
}
