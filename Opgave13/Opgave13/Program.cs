using System;

namespace Opgave13
{
    class Program
    {
        static void Main(string[] args)
        {
            var currentSelectedEur = true;
            var enterPressed = false;
            while (!enterPressed)
            {
                Console.WriteLine(currentSelectedEur ? "[EUR] : USD" : "EUR : [USD]");
                var key = Console.ReadKey();
                Console.Clear();
                switch (key.Key)
                {
                    case ConsoleKey.LeftArrow:
                    case ConsoleKey.RightArrow:
                        currentSelectedEur = !currentSelectedEur;
                        break;
                    case ConsoleKey.Enter:
                        enterPressed = true;
                        break;
                }
            }
            Console.WriteLine("Indtast beløb");
            var amount = double.Parse(Console.ReadLine());
            var rate = currentSelectedEur ? 7.44 : 7.31;
            Console.WriteLine($"{amount} {(currentSelectedEur ? "euro" : "dollar")} er {amount * rate}kr");
        }
    }
}