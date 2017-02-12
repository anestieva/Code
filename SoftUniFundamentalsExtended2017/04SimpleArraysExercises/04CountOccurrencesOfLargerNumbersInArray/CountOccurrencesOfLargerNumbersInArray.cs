using System;
using System.Linq;

//  Read an array of real numbers and a number p. Find how many elements are bigger than p in the array and prdouble the count.

class CountOccurrencesOfLargerNumbersInArray
{
    static void Main()
    {
        double[] array = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
        double p = double.Parse(Console.ReadLine());
        double count = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < p)
            {
                count++;
            }
        }
        Console.WriteLine(count);
    }
}