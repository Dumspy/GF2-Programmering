using System;

namespace OpgaveA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Indtast dit navn: ");
            var navn = Console.ReadLine();
            Console.Write("Indtast dit alder: ");
            var alder = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Du hedder {0} og er {1} år gammel.", navn, alder);
        }
    }
}