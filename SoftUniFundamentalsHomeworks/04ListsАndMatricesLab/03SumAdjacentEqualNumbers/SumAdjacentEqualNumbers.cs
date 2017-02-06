using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//  Input                Output                 Explanation
//  3 3 6 1	             12 1	                3 3 6 1 => 6 6 1 => 12 1

class SumAdjacentEqualNumbers
{
    static void Main()
    {
        List<decimal> nums = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();

        for (int i = 1; i < nums.Count; i++)
        {
            if (nums[i - 1] == nums[i])
            {
                nums[i - 1] += nums[i];
                nums.RemoveAt(i);
                i = 0;
            }
        }
        Console.WriteLine(String.Join(" ", nums));
    }
}