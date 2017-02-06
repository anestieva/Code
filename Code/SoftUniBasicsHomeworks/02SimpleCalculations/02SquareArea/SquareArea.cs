using System;

class SquareArea
{
    static void Main()
    {
        Console.Write("a = ");

        double a = double.Parse(Console.ReadLine());
        double result = a * a;

        Console.WriteLine("Square = {0}", result);
    }
}