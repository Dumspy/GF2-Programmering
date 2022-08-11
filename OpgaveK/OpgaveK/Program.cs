using System;

namespace OpgaveK
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indtast hvad tabel du vil se de første 10 tal for:");
            var tal = int.Parse(Console.ReadLine());
            var sum = 0;
            for (var i = 1; i <= 10; i++)
            {
                sum += tal * i;
                Console.WriteLine($"{tal} * {i} = {tal * i}");
            }
            Console.WriteLine($"Summen af de første 10 tal af {tal} tablen er {sum}");
        }
    }
}