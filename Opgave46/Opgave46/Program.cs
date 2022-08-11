using System;

namespace Opgave46
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var waitingForEnter = true;
            var oneTimeTicket = true;
            Console.WriteLine("Naviger med piltasterne og gå videre med enter");
            do
            {
                Console.WriteLine(oneTimeTicket ? "[Enkeltbilletter] : 10-turskort" : "Enkeltbilletter : [10-turskort]");
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.Enter:
                        waitingForEnter = false;
                        break;
                    case ConsoleKey.LeftArrow:
                    case ConsoleKey.RightArrow:
                        oneTimeTicket = !oneTimeTicket;
                        break;
                }
                Console.Clear();
            }while(waitingForEnter);
            
            Console.WriteLine("Du har valgt {0}", oneTimeTicket ? "enkeltbilletter" : "10-turskort");
            Console.WriteLine("Hvor mange voksen {0} ønsker du at købe", oneTimeTicket ? "enkeltbilletter" : "10-turskort");
            var adultTickets = int.Parse(Console.ReadLine());
            Console.WriteLine("Hvor mange af de voksne er Pensionister, efterlønsmodtagere, arbejdsledige, borgere på ledighedsydelse, dagpengemodtagere eller studerende");
            var cheapAdultTickets = int.Parse(Console.ReadLine());
            adultTickets -= cheapAdultTickets;
            Console.WriteLine("Hvor mange børne {0} ønsker du at købe", oneTimeTicket ? "enkeltbilletter" : "10-turskort");
            var childTickets = int.Parse(Console.ReadLine());
            Console.WriteLine("Hvor mange af de børne er under 7år");
            var cheapChildTickets = int.Parse(Console.ReadLine());
            childTickets -= cheapChildTickets;

            var adultTotal = (adultTickets * (oneTimeTicket ? 42 : 330));
            var childTotal = (childTickets * (oneTimeTicket ? 15 : 135)); 
            var cheapAdultTotal = (cheapAdultTickets * (oneTimeTicket ? 23 : 175));
            
            Console.WriteLine("{0} total pris", oneTimeTicket ? "enkeltbilletter" : "10-turskort");
            Console.WriteLine("{0} voksne {2} {1}kr",adultTickets, adultTotal, oneTimeTicket ? "enkeltbilletter" : "10-turskort");
            Console.WriteLine("{0} alternativ voksne {2} {1}kr",cheapAdultTickets, cheapAdultTotal, oneTimeTicket ? "enkeltbilletter" : "10-turskort");
            Console.WriteLine("{0} børne {2} {1}kr", childTickets, childTotal, oneTimeTicket ? "enkeltbilletter" : "10-turskort");
            Console.WriteLine("{0} børn under 7 {1} 0kr",cheapChildTickets, oneTimeTicket ? "enkeltbilletter" : "10-turskort");
            Console.WriteLine("Total pris: {0}kr", adultTotal + childTotal + cheapAdultTotal);
        }
    }
}