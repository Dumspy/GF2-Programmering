using System;

namespace Opgave47
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indtast 2 teskter for at finde ud af hvilken af dem er større");
            Console.WriteLine("Indtast tekst 1");
            string tekst1 = Console.ReadLine();
            Console.WriteLine("Indtast tekst 2");
            string tekst2 = Console.ReadLine();
            
            if (tekst1.Length > tekst2.Length)
            {
                Console.WriteLine("Teksten 1 er længere");
            }
            else if (tekst1.Length < tekst2.Length)
            {
                Console.WriteLine("Teksten 2 er længere");
            }
            else
            {
                Console.WriteLine("Teksten 1 og 2 er lige lange");
            }
        }
    }
}