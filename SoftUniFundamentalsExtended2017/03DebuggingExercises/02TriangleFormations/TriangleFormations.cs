using System;

namespace Ttiangle__Formations
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            if (a == 0 && b == 0 && c == 0)
            {
                Console.WriteLine("Invalid Triangle.");
            }
            else if (Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2))
            {
                Console.WriteLine("Triangle is valid.");
                Console.WriteLine("Triangle has a right angle between sides a and b");
            }
            else if (Math.Pow(b, 2) + Math.Pow(c, 2) == Math.Pow(a, 2))
            {
                Console.WriteLine("Triangle is valid.");
                Console.WriteLine("Triangle has a right angle between sides b and c");
            }
            else if (Math.Pow(c, 2) + Math.Pow(a, 2) == Math.Pow(b, 2))
            {
                Console.WriteLine("Triangle is valid.");
                Console.WriteLine("Triangle has a right angle between sides a and c");

            }
            else if ((a + b > c) && (a + c > b) && (b + c > a))
            {
                Console.WriteLine("Triangle is valid.");
                Console.WriteLine("Triangle has no right angles");
            }
            else
            {
                Console.WriteLine("Invalid Triangle.");
            }
        }
    }
}