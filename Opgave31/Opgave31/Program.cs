using System;

namespace Opgave31
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indtast hvad tabel du vil have");
            int tabel = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{i} * {tabel} = {tabel * i}");
            }
        }
    }
}