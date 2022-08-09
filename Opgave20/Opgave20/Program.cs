using System;

namespace Opgave20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indtast 2 tal programmet returner det største");
            var tal1 = int.Parse(Console.ReadLine());
            var tal2 = int.Parse(Console.ReadLine());
            if (tal1 > tal2)
            {
                Console.WriteLine($"{tal1} er større end {tal2}");
            }else if (tal1 == tal2)
            {
                Console.WriteLine($"{tal1} er lig med {tal2}");
            }
            else
            {
                Console.WriteLine($"{tal2} er større end {tal1}");
            }
        }
    }
}