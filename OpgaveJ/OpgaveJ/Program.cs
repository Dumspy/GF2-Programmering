using System;

namespace OpgaveJ
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var i = 4; i <= 16; i++)
            {
                for (var j = 4; j <= 40; j++)
                {
                    if(i == 4 || i == 16 || j == 4 || j == 40)
                    {
                        Console.SetCursorPosition(j,i);
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
            }
            
            Console.SetCursorPosition(4+31/2, 3+12/2);
            Console.Write("Felix");
            Console.ReadKey();
        }
    }
}