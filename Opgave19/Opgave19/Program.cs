using System;

namespace Opgave19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kredit aftale");
            Console.WriteLine("Indtast alder");
            
            var alder = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(alder >= 18 ? "Du er over 18 og derfor godkendt" : "Du er ikke over 18 og derfor ikke godkendt");
        }
    }
}