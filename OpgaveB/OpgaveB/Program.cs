using System;

namespace OpgaveB
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indtast alder: ");
            var alder = int.Parse(Console.ReadLine());
            Console.WriteLine("Indtast saldo: ");
            var saldo = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Jeg er {0} år gammel og har {1} kr i banken. Jeg gik ud af 10 klasse i 2019 og er skal starte på TEC-Ballerup den 20. august 2020", alder, saldo);
        }
    }
}