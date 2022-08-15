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
            printTitle();
            Console.Write("Indtast mængde af børnebilletter: ");
            var children = int.Parse(Console.ReadLine());
            Console.Write("Indtast mængde af voksenbilletter: ");
            var adults = int.Parse(Console.ReadLine());
            var totalSeats = children + adults;
            if (await getSeats(path) < totalSeats)
            {
                Console.WriteLine("Der er ikke nok ledige sæder");
                return;
            }

            var totalPrice = children * 30 + adults * 65;
            Console.WriteLine("Din totalpris er: {0}", totalPrice);
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
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("TEC Ballerup Stadion");
            Console.ResetColor();
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