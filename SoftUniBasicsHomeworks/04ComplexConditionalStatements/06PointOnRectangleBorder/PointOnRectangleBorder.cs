using System;

class PointOnRectangleBorder
{
    static void Main()
    {
        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());
        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());

        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());

        bool isOnTop = (y == y1) && (x >= x1 && x <= x2);
        bool isOnBottom = (y == y2) && (x >= x1 && x <= x2);
        bool isOnLeft = (x == x1) && (y >= y1 && y <= y2);
        bool isOnRight = (x == x2) && (y >= y1 && y <= y2);

        if (isOnTop || isOnBottom || isOnLeft || isOnRight)
        {
            Console.WriteLine("Border");
        }
        else
        {
            Console.WriteLine("Inside / Outside");
        }


    }
}