using System;

namespace Opgave25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hvor mange enklteværelser ønskes:");
            int antalE = Convert.ToInt32(Console.ReadLine());
            int ePris = 0;
            if (antalE != 0)
            {
                for (int i = 0; i < antalE; i++)
                {
                    Console.WriteLine("Hvor mange dage ønsker du at bo i enkeltværelse nummer {0}?",i+1);
                    ePris += 765 * Convert.ToInt32(Console.ReadLine());
                }
                
            }
            Console.WriteLine("Hvor mange dobbeltværelser ønskes:");
            int antalD = Convert.ToInt32(Console.ReadLine());
            int dPris = 0;
            if (antalD != 0)
            {
                for (int i = 0; i < antalD; i++)
                {
                    Console.WriteLine("Hvor mange dage ønsker du at bo i dobbeltværelser nummer {0}?",i+1);
                    dPris += 980 * Convert.ToInt32(Console.ReadLine());
                }
                
            }
            Console.WriteLine("Hvor mange familieværelser ønskes:");
            int antalF = Convert.ToInt32(Console.ReadLine());
            int fPris = 0;
            if (antalF != 0)
            {
                for (int i = 0; i < antalF; i++)
                {
                    Console.WriteLine("Hvor mange dage ønsker du at bo i familieværelser nummer {0}?",i+1);
                    fPris += 1250 * Convert.ToInt32(Console.ReadLine());
                }
                
            }
            
            Console.WriteLine("Pris information");
            Console.WriteLine("{0} Enkeltværelser total: {1}", antalE, ePris);
            Console.WriteLine("{0} Doubletværsel total: {1}", antalD, dPris);
            Console.WriteLine("{0} Familieværelser total: {1}", antalF, fPris);
        }
    }
}