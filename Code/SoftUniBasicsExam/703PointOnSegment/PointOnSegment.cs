using System;

class PointOnSegment
{
    static void Main()
    {
        double first = double.Parse(Console.ReadLine());
        double second = double.Parse(Console.ReadLine());
        double point = double.Parse(Console.ReadLine());

        double firstDifference = Math.Abs(point - first);
        double secondDifference = Math.Abs(point - second);

        if (point >= first && point <= second || point <= first && point >= second)
        {
            Console.WriteLine("in");
            Console.WriteLine(Math.Min(firstDifference,secondDifference));

        }
        else
        {
            Console.WriteLine("out");
            Console.WriteLine(Math.Min(firstDifference, secondDifference));

        }
    }
}