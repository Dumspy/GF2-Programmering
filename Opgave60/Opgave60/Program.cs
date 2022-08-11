using System;

namespace Opgave60
{
    class Program
    {
        static void Main(string[] args)
        {
            var waitingForNumber = true;
            var number = 0;
            while (waitingForNumber)
            {
                Console.Write("Indtast et helt tal:");
                try
                {
                    number = int.Parse(Console.ReadLine());
                    waitingForNumber = false;
                }
                catch
                {
                    Console.WriteLine("Du skal indtaste et helt tal");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            Console.WriteLine($"Du indtastede {number}");
        }
    }
}