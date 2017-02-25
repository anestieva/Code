using System;
using System.Linq;

//  Input	                        Output
//  1 1 1 1 4 2 1 3 8 9 5	        1 4 8 9

class ArrayElementsEqualToTheirIndex
{
    static void Main()
    {
        int[] numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == i)
            {
                Console.Write(numbers[i] + " ");
            }
        }
        Console.WriteLine();
    }
}