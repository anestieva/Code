using System;

class OddEvenSum
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        double evenSum = 0;
        double oddSum = 0;

        for (int i = 1; i <= number; i++)
        {
            int numbers = int.Parse(Console.ReadLine());
            if (i % 2 == 0)
            {
                evenSum += numbers;
            }
            else if (i % 2 != 0)
            {
                oddSum += numbers;
            }
        }

        double areEqual = Math.Abs(evenSum - oddSum);

        if (areEqual == 0)
        {
            Console.WriteLine("Yes, sum = {0}", evenSum);
        }
        else
        {
            Console.WriteLine("No, diff = {0}", areEqual);
        }
    }
}