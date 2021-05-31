using System;

namespace Zahlen1To100
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i<= 100; i++)
            {

                if(i % 10 == 0) // Überprüft ob i durch 10 ohne Rest teilbar ist
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.Write(i.ToString() + ", ");
                }

                
            }
        }
    }
}
