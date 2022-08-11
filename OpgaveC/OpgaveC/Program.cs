using System;

namespace OpgaveC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indtast modstand");
            float r = float.Parse(Console.ReadLine());
            Console.WriteLine("Indtast størmstyrken");
            float i = float.Parse(Console.ReadLine());

            float v = r * i;
            
            Console.WriteLine("Spændingskraften er: {0}", v);
        }
    }
}