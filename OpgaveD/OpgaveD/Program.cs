using System;

namespace OpgaveD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sum og gemmensnit af tre tal");
            Console.WriteLine("Indtast første tal");
            var tal1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Indtast andet tal");
            var tal2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Indtast tredje tal");
            var tal3 = int.Parse(Console.ReadLine());
            var sum = tal1 + tal2 + tal3;
            var gennemsnit = sum / 3;
            Console.WriteLine("Summen er {0} og gennemsnittet er {1}",sum,gennemsnit);
        }
    }
}