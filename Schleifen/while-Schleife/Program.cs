using System;

namespace while_Schleife
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte geben Sie eine Zahl im Intervall von 1 bis 10 ein:");
            double eingabe = UserInput();

            while(eingabe < 1 || eingabe > 10)
            {
                Console.WriteLine("Bitte geben Sie wirklich eine Zahl im Intervall von 1 bis 10 ein:");
                eingabe = UserInput();
            }
        }

        static double UserInput()
        {
            double eingabe;
            try
            {
                eingabe = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException exc)
            {
                Console.WriteLine($"Bitte geben Sie eine Zahl ein! Fehler: {exc.Message}");
                eingabe = -1;
            }

            return eingabe;
        }

    }
}
