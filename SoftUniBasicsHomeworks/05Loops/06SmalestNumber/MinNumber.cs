using System;

class MinNumber
{
    static void Main()
    {
        int numberCount = int.Parse(Console.ReadLine());

        double minValue = double.MaxValue; ;

        for (int i = 0; i < numberCount; i++)
        {
            double number = double.Parse(Console.ReadLine());
            if (number < minValue)
            {
                minValue = number;
            }
        }
        Console.WriteLine(minValue);
    }
}