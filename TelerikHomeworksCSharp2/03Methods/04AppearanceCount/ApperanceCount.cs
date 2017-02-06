using System;
using System.Linq;

// Write a method that counts how many times given number appears in a given array.Write a test program to check if the method is working correctly.

class AppearanceCount
{
    static void Main()
    {
        Console.ReadLine();
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int searchingNumber = int.Parse(Console.ReadLine());

        Console.WriteLine(CountAppearance(numbers, searchingNumber));
    }

    static int CountAppearance(int[] numbers, int searchingNumber)
    {
        int counter = 0;
        foreach (var number in numbers)
        {
            if (number == searchingNumber)
            {
                counter++;
            }
        }

        return counter;
    }
}