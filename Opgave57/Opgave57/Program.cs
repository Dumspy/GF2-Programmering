using System;

namespace Opgave57
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Karakter gemmensnits udregner");
            Console.WriteLine("Indtast mængde af karakterer du vil regned gemmensnittet af");
            var antal = Convert.ToInt32(Console.ReadLine());
            var sum = 0;
            for (var i = 0; i < antal; i++)
            {
                string karakterString;
                var karakterParsed = 0;
                do
                {
                    Console.WriteLine("Indtast karakter");
                    karakterString = Console.ReadLine();
                    if(validteKarakter(karakterString)){
                        karakterParsed = Convert.ToInt32(karakterString);
                    }
                    else
                    {
                        Console.WriteLine("Forkert format for karakter indtastet exemplvis 02 for 2");
                    }
                } while (karakterParsed == 0);

                sum += karakterParsed;
            }
            
            var gemmensnitt = sum / antal;
            Console.WriteLine($"Gemmensnittet er {gemmensnitt}");
        }
        
        private static bool validteKarakter(string karakter)
        {
            if(karakter.Length != 2)
            {
                return false;
            }

            var karakterParsed = int.Parse(karakter);
            
            if (karakterParsed < 0 || karakterParsed > 12)
            {
                return false;
            }

            return true;
        }
    }
}