using System;

namespace OpgaveN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gæt et tilfældigt tal mellem x og y");
            Console.WriteLine("Indtast x værdien: ");
            var x = int.Parse(Console.ReadLine());
            Console.WriteLine("Indtast y værdien: ");
            var y = int.Parse(Console.ReadLine());
            var rnd = new Random();
            var tal = rnd.Next(x, y);
            int gæt;
            var antalGæt = 0;
            do
            {
                Console.WriteLine("Indtast dit gæt: ");
                gæt = int.Parse(Console.ReadLine());
                Console.Clear();
                antalGæt++;
            }while(gæt!=tal);
            Console.WriteLine($"Du gættede det rigtige tal({tal}) på {antalGæt} forsøg");

        }
    }
}