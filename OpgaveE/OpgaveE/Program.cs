using System;

namespace OpgaveE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indtast temperaturen i celcius");
            var temp = double.Parse(Console.ReadLine());
            if (temp > 35)
            {
                Console.WriteLine("Det for varmt");
            }else if (35 > temp && temp > 25)
            {
                Console.WriteLine("Det er ok");
            }
            else
            {
                Console.WriteLine("Det for koldt");
            }
        }
    }
}