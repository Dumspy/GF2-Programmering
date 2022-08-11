using System;

namespace Opgave49
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indtast en tekest som skal spjelvendes");
            var text = Console.ReadLine();
            var newText = "";
            for (var i = text.Length-1; i >= 0; i--)
            {
                newText += text[i];
            }
            Console.WriteLine(newText);
        }
    }
}