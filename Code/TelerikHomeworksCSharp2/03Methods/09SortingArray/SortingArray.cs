using System;
using System.Linq;

// Write a method that returns the maximal element in a portion of array of integers starting at given index. 
// Using it write another method that sorts an array in ascending / descending order. Write a program that sorts a given array.

class SortingArray
{
    static void Main(string[] args)
    {
        int length = int.Parse(Console.ReadLine());
        decimal[] arrayOfNumbers = Console.ReadLine().Split(' ').Select(s => decimal.Parse(s)).ToArray();

        SortArray(arrayOfNumbers);
        Console.WriteLine(string.Join(" ", arrayOfNumbers));
    }

    static void SortArray(decimal[] array)
    {
        Array.Sort(array);
    }
}
