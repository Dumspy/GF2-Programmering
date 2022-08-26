using System;
using System.IO;
using System.Threading.Tasks;

namespace Opgave61_62
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory),"test.txt");
            startUp(path);
            int children, adults;
            do
            {
                Console.Clear();
                printTitle();
                printDate();
                Console.WriteLine("Du kan maks bestille 10 af hver type billet");
                Console.Write("Indtast mængde af børnebilletter: ");
                children = int.Parse(Console.ReadLine());
                Console.Write("Indtast mængde af voksenbilletter: ");
                adults = int.Parse(Console.ReadLine());
            } while (children>=10 || adults>=10);
            Console.Clear();
            printTitle();
            printDate();
            
            var totalSeats = children + adults;
            if (await getSeats(path) < totalSeats)
            {
                Console.WriteLine("Der er ikke nok ledige sæder");
                return;
            }

            var isMember = false;
            var canContinue = false;
            do
            {
                Console.Write("Er du medlem af klubbens foreningsgruppe? (J/N)");
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.J:
                        isMember = true;
                        canContinue = true;
                        break;
                    case ConsoleKey.N:
                        canContinue = true;
                        break;
                }
            } while (!canContinue);
            Console.Clear();
            printTitle();
            printDate();
            double totalPrice = children * 30 + adults * 65;
            var discount = isMember ? totalPrice * 0.1 : 0;
            totalPrice -= discount;
            var totalPriceUsd = Math.Round(totalPrice / (625.45 / 100));
            if(isMember)
                Console.WriteLine("Da du er medlem af klubbens foreningsgruppe får du 10% rabat som svare til {0:N2} kr.", discount);
            Console.WriteLine("Din totalpris er: {0:N2} eller {1:N2} usd", totalPrice, totalPriceUsd);
            Console.WriteLine("Tak for din bestilling");
            updateSeats(path, totalSeats);
        }

        private static async void startUp(string path)
        {
            if (System.IO.File.Exists(path)) return;
            await System.IO.File.WriteAllTextAsync(path, "100");
        }
        
        private static void printTitle()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("TEC Ballerup Stadion");
            Console.ResetColor();
        }

        private static void printDate()
        {
            var date = DateTime.Now;
            Console.SetCursorPosition(Console.WindowWidth - date.ToString().Length, 0);
            Console.WriteLine("{0} {1} {2}", date.DayOfWeek, date.Day, date.ToString("MMMM"));
        }

        private static async Task updateSeats(string path, int seats)
        {
            var currentSeats = await getSeats(path);
            await System.IO.File.WriteAllTextAsync(path, (currentSeats - seats).ToString());
        }
        private static async Task<int> getSeats(string path)
        {
            var file = await System.IO.File.ReadAllTextAsync(path);
            return int.Parse(file);
        }
    }
}