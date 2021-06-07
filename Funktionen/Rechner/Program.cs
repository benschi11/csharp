using System;

namespace Rechner
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean quit = false;

            while (quit == false)
            {
                Console.WriteLine("Bitte geben Sie die Rechenoperation an: (1) Addieren, (2) Subtrahieren, (3) Multiplizieren, (4) Dividieren, (0) Beenden");

                int eingabe = Convert.ToInt32(Console.ReadLine());

                if (eingabe == 1)
                {
                    Addieren();
                }
                else if (eingabe == 2)
                {
                    Subtrahieren();
                }
                else if (eingabe == 3)
                {
                    Multiplizieren();
                }
                else if (eingabe == 4)
                {
                    Dividieren();
                }
                else if (eingabe == 0)
                {
                    quit = true;
                }
            }
        }

        static void Dividieren()
        {
            Console.WriteLine("-------------- Dividieren --------------");
            Console.WriteLine("Bitte geben Sie den Divident ein:");
            double s1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Bitte geben Sie den Divisor ein:");
            double s2 = Convert.ToDouble(Console.ReadLine());

            if (s2 == 0) // Division durch 0
            {
                Console.WriteLine("Bitte keine Division durch 0!");
            }
            else
            {
                double quotient = s1 / s2;
                Console.WriteLine($"Das Ergebnis Ihrer Division lautet {quotient}");
            }
        }

        static void Multiplizieren()
        {
            Console.WriteLine("-------------- Multiplikation --------------");
            Console.WriteLine("Bitte geben Sie den ersten Faktor ein:");
            double s1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Bitte geben Sie den zweiten Faktor ein:");
            double s2 = Convert.ToDouble(Console.ReadLine());

            double produkt = s1 * s2;
            Console.WriteLine($"Das Ergebnis Ihrer Multiplikation lautet {produkt}");
        }

        static void Subtrahieren()
        {
            Console.WriteLine("-------------- Subtraktion --------------");
            Console.WriteLine("Bitte geben Sie Minuend ein:");
            double s1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Bitte geben Sie den Subtrahend ein:");
            double s2 = Convert.ToDouble(Console.ReadLine());

            double differenz = s1 - s2;
            Console.WriteLine($"Das Ergebnis Ihrer Subraktion lautet {differenz}");
        }

        static void Addieren()
        {
            Console.WriteLine("-------------- Addition --------------");

            Console.WriteLine("Bitte geben Sie den ersten Summanden ein:");
            string eingabe = Console.ReadLine();
            double summe = 0; // Anfangswert

            while (eingabe != "*")
            {
                double s1 = Convert.ToDouble(eingabe);
                summe += s1;

                Console.WriteLine("Bitte geben Sie einen weiteren Summanden ein:");
                eingabe = Console.ReadLine();
            }



            Console.WriteLine($"Das Ergebnis Ihrer Addition lautet {summe}");
        }
    }
}
