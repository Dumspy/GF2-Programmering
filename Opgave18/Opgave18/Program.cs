using System;

namespace Opgave18
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            if (number > 4)
            {
                Console.WriteLine("Tallet er større end 4");
            }else if (number < 4)
            {
                Console.WriteLine("Tallet er mindre end 4");
            }
            if(number != 4)
            {
                Console.WriteLine("Tallet er ikke 4");
            }
            
        } 
    }
}