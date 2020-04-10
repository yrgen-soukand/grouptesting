using System;

namespace Exercise1_Nelinurgad
{
    public class Program
    {
        static void Main(string[] args)
        {           
            double area = 20;
            double area2 = 80;
            double area3 = 78;

            double height = 5;
            double height2 = 20;
            double height3 = 25;

            double width1 = WidthFinder(area, height);
            double circumference1 = CircumferenceFinder(area, height);
            
            double width2 = WidthFinder(area2, height2);
            double circumference2 = CircumferenceFinder(area2, height2);
            
            double width3 = WidthFinder(area3, height3);

            Console.WriteLine("Esimese nelinurga laius on {0} ja ümbermõõt {1}.", width1, circumference1);
            Console.WriteLine("Teise nelinurga laius on {0} ja ümbermõõt {1}.", width2, circumference2);
            Console.WriteLine("Kolmanda nelinurga laius on {0}.", width3);
            Console.ReadLine();
        }

        public static double WidthFinder(double area, double height)
        {
            double result;
            result = area / height;
            return result;
        }

        public static double CircumferenceFinder(double area, double height)
        {
            double result;
            result = 2 * ((area / height) + height);
            return result;
        }
    }
}
