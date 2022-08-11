using System;

namespace OpgaveM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indtast et tal mellem 0 og 255");
            var tal = Convert.ToInt32(Console.ReadLine());

            if (tal < 0 || tal > 255)
            {
                Console.WriteLine("Tallet er ikke mellem 0 og 255");
                return;
            }
            Console.Write(Convert.ToString(tal,2));
        }
    }
}