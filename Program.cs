using System;

// Посчитать расстояние от точки до прямой, заданной двумя разными точками.
//  https://habr.com/ru/post/148325/
namespace DistanceStraight2Point
{
    class Program
    {
        static int CheckStr(string s)
        {
          return s.IndexOf(';');
        }

        static double ParseX(string s, int p)
        {
            return double.Parse(s.Substring(0, p));
        }

        static double ParseY(string s, int p)
        {
            return double.Parse(s.Substring(p + 1));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("FirstPoint: (X; Y)");
            string s = Console.ReadLine();
            int p = CheckStr(s);
            if (p == 0)
            {
                Console.WriteLine("Wrong entering point");
                return;
            }
            double X1 = ParseX(s, p);
            double Y1 = ParseY(s, p);

            Console.WriteLine("SecondPoint: (X; Y)");
            s = Console.ReadLine();
            p = CheckStr(s);
            if (p == 0)
            {
                Console.WriteLine("Wrong entering point");
                return;
            }
            double X2 = ParseX(s, p);
            double Y2 = ParseY(s, p);
            Console.WriteLine("Point: (X; Y)");
            s = Console.ReadLine();
            p = CheckStr(s);
            if (p == 0)
            {
                Console.WriteLine("Wrong entering point");
                return;
            }
            double X0 = ParseX(s, p);
            double Y0 = ParseY(s, p);

            double h = Math.Abs(((X2 - X1) * (Y0 - Y1) - (Y2 - Y1) * (X0 - X1))/Math.Sqrt((X2 - X1) * (X2 - X1) + (Y2 - Y1) * (Y2 - Y1)));
            Console.WriteLine("The distance is {0}", h);
        }
    }
}
