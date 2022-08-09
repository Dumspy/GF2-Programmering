using System;

namespace Opgave34
{
    class Program
    {
        static void Main(string[] args)
        {
            var Random = new Random();
            var i = 0;
            do
            {
                var value = Random.Next(1, 7);
                Console.WriteLine("Terning viste: {0}", value);
                i++;
            } while (i <= 100);
        }
    }
}