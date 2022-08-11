using System;

namespace Opgave53
{
    class Program
    {
        static void Main(string[] args)
        {
            colorPrint("uwuw", "gul");
            colorPrint("uwuw", "rød");
            colorPrint("uwuw", "blå");
            colorPrint("uwuw", "sort");
        }

        private static void colorPrint(string Input, string Color)
        {
            switch (Color.ToLower())
            {
                case "rød":
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case "blå":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case "grøn":
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case "gul":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case "hvid":
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case "sort":
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
            }

            Console.WriteLine(Input);
        }
    }
}