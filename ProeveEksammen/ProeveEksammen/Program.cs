using System;

namespace ProeveEksammen
{
    class Program
    {
        static void Main(string[] args)
        {
            // Array af menu items
            var menuItems = new String[] { "B (Burger)", "BP (Burger med pommes fris)", "BPC (Burger med pommes fris og cola)" };
            // Array af priser i samme order som menu items
            var menuPrices = new double[] { 35, 55 ,75};
            // variable som holder værdien af valgte menu item
            var currentMenuItem = 0;
            // variable som bruges til do while loop til at nå man trykker enter at man kommer ud af den
            var waitingForEnter = true;
            do
            {
                // Skriver information om brug af menuen til brugeren
                Console.WriteLine("Brug pil op ned for at navigere i menuen og enter for at vælge");
                // Looper over alle menuItems og skriver dem putter en ">" foran det menu item som har samme index som currentMenuItem
                for (int i = 0; i < menuItems.Length; i++)
                {
                    Console.WriteLine(currentMenuItem == i ? $">{menuItems[i]}" : menuItems[i]);
                }
                // Læser input fra brugeren
                switch (Console.ReadKey().Key)
                {
                    //Går sætter værdien for looped til true ved enter tryk
                    case ConsoleKey.Enter:
                        waitingForEnter = false;
                        break;
                    // Hvis pil op trykkes sætter værdien for valgte menu item ned med 1 og checker om man ikke har kørt ud mænged af items hvis man er sætter den værdien til den sidste i arrayed
                    case ConsoleKey.UpArrow:
                        currentMenuItem--;
                        if (currentMenuItem < 0)
                        {
                            currentMenuItem = menuItems.Length - 1;
                        }

                        break;
                    // Hvis pil ned trykkes sætter værdien for valgte menu item op med 1 og checker om man ikke har kørt ud mænged af items hvis man er sætter den værdien til den første i arrayed
                    case ConsoleKey.DownArrow:
                        currentMenuItem++;
                        if (currentMenuItem > menuItems.Length - 1)
                        {
                            currentMenuItem = 0;
                        }

                        break;
                }

                Console.Clear();
            } while (waitingForEnter);
            // variabel som holder antallet af menuer man vil ha
            var amount = 0;

            do
            {
                try
                {
                    Console.WriteLine("Du har valgt {0} hvor mange ønsker du: ",menuItems[currentMenuItem]);
                    amount = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.Clear();
                    Console.WriteLine("Du skal indtaste et tal");
                }
            } while (!(amount > 0));

            // Udregner totalprisen for valgte menu item
            var totalPris = amount * menuPrices[currentMenuItem];
            // Udregner totalprisen for valgte menu item i euro
            var totalPrisEur = totalPris / 7.44;
            // Fortæller brugen hvad prisen er
            Console.WriteLine("Du har bestilt {0} {1} til {2} kr eller {3:n2} euro", amount, menuItems[currentMenuItem], totalPris, totalPrisEur);
        }
    }
}