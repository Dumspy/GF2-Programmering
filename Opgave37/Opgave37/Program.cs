using System;

namespace Opgave37
{
    class Program
    {
        static void Main(string[] args)
        {
            var answer = "faaborg";
            var attempt = "";
            var attempts = 0;
            
            Console.WriteLine("Gæt en by på fyn:");
            
            do
            {
                attempt = Console.ReadLine().ToLower();
                attempts++;
            }while(answer != attempt);
            
            Console.WriteLine($"Du gættede rigtigt på {attempts} forsøg");
        }
    }
}