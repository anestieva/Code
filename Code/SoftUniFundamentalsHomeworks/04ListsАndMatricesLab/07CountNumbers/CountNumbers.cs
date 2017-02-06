using System;
using System.Collections.Generic;
using System.Linq;

//  Input                   Output
//  8 2 2 8 2 2 3 7	        2 -> 4
//                          3 -> 1
//                          7 -> 1
//                          8 -> 2

class CountNumbers
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

        int[] count = new int[1001];

        foreach (var num in numbers)
        {
            count[num]++;
        }

        for (int i = 0; i < count.Length; i++)
        {
            if (count[i] > 0)
            {
                Console.WriteLine("{0} => {1}", i, count[i]);
            }
        }
    }
}