using System;

namespace Schleifen
{
    class Program
    {
        static void Main(string[] args)
        {
            double summe = 0; // Summenvariable auf 0 initialisieren

            Console.WriteLine("Bitte geben Sie 10 Zahlen ein:");
            for(int i = 1;i<=10;i++) // i=i+1 <=> i++
            {
                Console.WriteLine("Bitte geben sie die " + i.ToString() + "te Zahl ein:");
                double a = Convert.ToDouble(Console.ReadLine());
                summe = summe + a; // summe += a;
            }

            Console.WriteLine($"Die Summe ihrer Zahlen lautet {summe}");
            

        }
    }
}
