using System;

namespace OpgaveL
{
    class Program
    {
        static void Main(string[] args)
        {
            // Som sådan er der ikke den store forskel på den her version og versionen i opgave 37 men det mest basic er vel at do while gangetere at det i loopet mens blir kørt en gang i forhold til det her der som sådan ikke ville behøves at køre loop hvis ikke det var for at jeg først læser hvad brugen skriver i loopet
            var bynavn = "faaborg";
            var attempts = 0;
            var input = "";
            while (input != bynavn)
            {
                Console.WriteLine("Gæt en by på fynn: ");
                input = Console.ReadLine();
                attempts++;
            }
            Console.WriteLine($"Du gættede det på {attempts} forsøg");
        }
    }
}