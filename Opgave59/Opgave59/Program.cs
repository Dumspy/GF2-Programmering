using System;

namespace Opgave59
{
    class Program
    {
        static void Main(string[] args)
        {
            var menuItems = new string[] { "1. Opret", "2. Rediger", "3. Slet", "4. Vis", "5. Afslut" };
            var waitingForEnter = true;
            var menuIndex = 0;
            do
            {
                for (var i = 0; i < menuItems.Length; i++)
                {
                    Console.WriteLine(i == menuIndex ? "> " + menuItems[i] : "  " + menuItems[i]);
                }
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.Enter:
                        waitingForEnter = false;
                        break;
                    case ConsoleKey.UpArrow:
                        menuIndex = menuIndex == 0 ? menuItems.Length - 1 : menuIndex - 1;
                        break;
                    case ConsoleKey.DownArrow:
                        menuIndex = menuIndex == menuItems.Length - 1 ? 0 : menuIndex + 1;
                        break;
                }
                Console.Clear();
            }while (waitingForEnter);
            
            Console.WriteLine("Valgte menu-item: " + menuItems[menuIndex]);
        }
    }
}