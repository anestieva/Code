using System;
using System.Collections.Generic;
using System.Linq;

//  Input                   Output
//  3 16 4 5 6 8 9         	16 9 4

class SquareNumbers
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        List<double> sqrtNumbers = new List<double>();

        for (int i = 0; i < numbers.Count; i++)
        {
            var sqrt = Math.Sqrt(numbers[i]);

            if (sqrt * sqrt == numbers[i])
            {
                sqrtNumbers.Add(numbers[i]);
            }
        }

        sqrtNumbers.Sort();
        sqrtNumbers.Reverse();

        Console.WriteLine(string.Join(" ", sqrtNumbers));
    }
}