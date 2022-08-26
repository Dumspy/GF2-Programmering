using System;

namespace Opgave37
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer = "faaborg";
            string input = "";
            int attempts = 0;
            
            Console.WriteLine("Gæt en by på fyn:");
            
            do
            {
                input = Console.ReadLine().ToLower();
                attempts++;
            }while(answer != input);
            
            Console.WriteLine($"Du gættede rigtigt på {attempts} forsøg");
        }
    }
}