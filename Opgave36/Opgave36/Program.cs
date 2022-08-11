using System;

namespace Opgave36
{
    class Program
    {
        static void Main(string[] args)
        {
            // Opreter et int variabel med navnet tal uden værdi
            int tal;
            do
            {
                // Printer en besked til brugeren
                Console.Write("Indtast et positivt tal: ");
                // Læser input fra brugeren
                tal = Convert.ToInt32(Console.ReadLine());
                // Tjekker om tal er større end eller lig med 0
                if (tal <= 0)
                {
                    // Printer en besked til brugeren om at de skal taste noget større end 0
                    Console.WriteLine("Du skal taste et tal større end 0");
                    Console.Write("Tryk Enter");
                    Console.ReadKey();
                }
                //Blir ved med at køre do while loopet, hvis tal ikke er større end 0
            } while (tal <= 0);
            // Printer en besked til brugeren
            Console.Write("Inddata er godkendt");
            Console.ReadKey();
        }
    }
}