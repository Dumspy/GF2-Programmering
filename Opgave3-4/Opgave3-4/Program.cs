using System;

namespace Opgave3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new string[7];
            data[0] = "Felix";
            data[1] = "Berger";
            data[2] = "Vej navn";
            data[3] = "6969";
            data[4] = "By navn";
            data[5] = "felix.enok.berger@gmail.com";
            data[6] = "12345678";
            
            for (var i = 0; i < data.Length; i++)
            {
                Console.SetCursorPosition(Console.WindowWidth/2, i + 1);
                Console.WriteLine(data[i]);
            }
        }
    }
}