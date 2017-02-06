using System;

class LeftAndRightSum
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        double firstSum = 0;
        double secondSum = 0;

        for (int i = 1; i <= number; i++)
        {
            int firstNumbers = int.Parse(Console.ReadLine());
            firstSum += firstNumbers;
        }

        for (int i = number+1; i <= number*2; i++)
        {
            int secondNumbers = int.Parse(Console.ReadLine());
            secondSum += secondNumbers;
        }

        double areEqual = Math.Abs(firstSum - secondSum);
        Console.WriteLine(areEqual);

        if (areEqual == 0)
        {
            Console.WriteLine("Yes, sum = {0}", firstSum);
        }
        else
        {
            Console.WriteLine("No, diff = {0}", areEqual);
        }
    }
}