using System;

namespace Opgave39
{
    class Program
    {
        static void Main(string[] args)
        {
            var password = "1234";
            var attempts = 0;
            string input;
            Console.WriteLine("Indtast din kode");
            do
            {
                input = Console.ReadLine();
                attempts++;
            }while(input != password & attempts < 5);

            if (attempts>=5)
            {
                Console.WriteLine("For mange forsøg brugt");
            }
            else
            {
                Console.WriteLine("Du har indtastet koden korrect");
            }
        }
    }
}