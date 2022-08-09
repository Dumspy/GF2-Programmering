using System;

namespace Opgave26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Login indtast brugernavn:");
            string brugernavn = Console.ReadLine();
            Console.WriteLine("Login indtast kodeord:");
            string kodeord = Console.ReadLine();
            
            if (brugernavn != "admin" || kodeord != "1234")
            {
                Console.WriteLine("Du er logget ind");
            }
            else
            {
                Console.WriteLine("Forkert brugernavn eller kodeord");
            }
        }
    }
}