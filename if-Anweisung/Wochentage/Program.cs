using System;

namespace Wochentage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte geben Sie eine Zahl von 1 bis 7 ein:");
            int eingabe = Convert.ToInt32(Console.ReadLine());

            switch (eingabe) // Überprüfe was in Variable 'eingabe' steht
            {
                case 1:
                    Console.WriteLine("Montag");
                    break;
                case 2:
                    Console.WriteLine("Dienstag");
                    break;
                case 3:
                    Console.WriteLine("Mittwoch");
                    break;
                case 4:
                    Console.WriteLine("Donnerstag");
                    break;
                case 5:
                    Console.WriteLine("Freitag");
                    break;
                case 6:
                    Console.WriteLine("Samstag");
                    break;
                case 7:
                    Console.WriteLine("Sonntag");
                    break;
                default:
                    Console.WriteLine("Sie sollten eine Zahl von 1 bis 7 eingeben.");
                    break;
            }
        }
    }
}
