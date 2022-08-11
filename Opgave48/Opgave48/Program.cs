using System;

namespace Opgave48
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indtast en tekest som skal ha fjernet alle mellemrum");
            string tekst = Console.ReadLine();
            string tekst2 = tekst.Replace(" ", "");
            Console.WriteLine(tekst2);
        }
    }
}