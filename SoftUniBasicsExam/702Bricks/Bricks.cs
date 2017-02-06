using System;

class Bricks
{
    static void Main()
    {
        double bricks = double.Parse(Console.ReadLine());
        double workers = double.Parse(Console.ReadLine());
        double car = double.Parse(Console.ReadLine());

        double result = Math.Ceiling(bricks / (workers * car));

        Console.WriteLine(result);
    }
}