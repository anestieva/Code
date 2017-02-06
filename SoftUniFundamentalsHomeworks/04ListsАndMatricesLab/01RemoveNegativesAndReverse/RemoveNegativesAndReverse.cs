using System;
using System.Collections.Generic;
using System.Linq;

// Програма, която чете лист от елементи, премахва негативните и го обръща

class RemoveNegativesAndReverse
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
        List<int> result = new List<int>();

        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] > 0)
            {
                result.Add(numbers[i]);
            }
        }

        result.Reverse();

        Console.WriteLine(string.Join(" ", result));
    }
}