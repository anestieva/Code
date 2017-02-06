using System;
using System.Linq;

class SumMinMaxFirstLastAverage
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[] numbers = new int[n];

        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        double sum = numbers.Sum();
        double min = numbers.Min();
        double max = numbers.Max();
        double first = numbers.First();
        double last = numbers.Last();
        double average = numbers.Average();
        double second = numbers.Skip(1).First();

        Console.WriteLine("Sum = {0}",sum);
        Console.WriteLine("Min = {0}", min);
        Console.WriteLine("Max = {0}", max);
        Console.WriteLine("First = {0}", first);
        Console.WriteLine("Last = {0}", last);
        Console.WriteLine("Average = {0}", average);      
    }
}