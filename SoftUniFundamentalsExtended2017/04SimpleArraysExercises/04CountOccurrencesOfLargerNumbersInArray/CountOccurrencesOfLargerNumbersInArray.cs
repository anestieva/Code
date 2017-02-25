using System;
using System.Linq;

//  Read an array of real numbers and a number p. Find how many elements are bigger than p in the array and prdecimal the count.

class CountOccurrencesOfLargerNumbersInArray
{
    static void Main()
    {
        decimal[] array = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(decimal.Parse).ToArray();
        decimal p = decimal.Parse(Console.ReadLine());
        decimal count = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > p)
            {
                count++;
            }
        }
        Console.WriteLine(count);
    }
}