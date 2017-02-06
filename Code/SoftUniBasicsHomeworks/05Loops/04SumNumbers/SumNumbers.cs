using System;

class SumNumbers
{
    static void Main()
    {
        int numberCount = int.Parse(Console.ReadLine());

        double sum = 0;

        for (int i = 0; i < numberCount; i++)
        {
            double number = double.Parse(Console.ReadLine());
            sum += number;
        }
        Console.WriteLine(sum);
    }
}