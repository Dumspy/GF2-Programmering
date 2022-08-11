using System;

namespace Opgave55
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Matematik.Firkant.Omkreds(5,5));
        }
    }

    public class Matematik
    {
        public class Circle
        {
            public static double Areal(double radius)
            {
                return Math.PI * Math.Pow(radius, 2);
            }

            public static double Omkreds(double radius)
            {
                return 2 * Math.PI * radius;
            }
        }

        public class Firkant
        {
            public static double Areal(double l, double b)
            {
                return l * b;
            }

            public static double Omkreds(double l, double b)
            {
                return 2 * (l + b);
            }
        }

        public class Trekant
        {
            public static double Areal(double h, double g)
            {
                return 0.5 / h * g;
            }

            public static double Omkreds(double h, double g)
            {
                return Math.Sqrt(Math.Pow(h, 2) + Math.Pow(g, 2)) + h + g;
            }
        }
    }
}