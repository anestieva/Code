using System;
using System.Linq;

class SumArrays
{
    static void Main()
    {
        int[] array1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[] array2 = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int length = Math.Max(array1.Length, array2.Length);

        int[] sumArray = new int[length];

        for (int i = 0; i < length; i++)
        {
            sumArray[i] = array1[i % array1.Length] + array2[i % array2.Length];
        }
        Console.WriteLine(string.Join(" ", sumArray));
    }
}