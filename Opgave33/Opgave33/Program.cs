using System;

namespace Opgave33
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            while (number != 50)
            {
                Console.Clear();
                Console.WriteLine("Indtast et tal");
                number = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("While stopped");
        }
    }
}