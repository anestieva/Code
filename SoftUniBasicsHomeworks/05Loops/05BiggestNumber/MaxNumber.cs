using System;

class MaxNumber
{
    static void Main()
    {
        int numberCount = int.Parse(Console.ReadLine());

        double biggestNumber = double.MinValue;

        for (int i = 0; i < numberCount; i++)
        {
            double number = double.Parse(Console.ReadLine());
            if (number > biggestNumber)
            {
                biggestNumber = number;
            }
        }
        Console.WriteLine(biggestNumber);
    }
}