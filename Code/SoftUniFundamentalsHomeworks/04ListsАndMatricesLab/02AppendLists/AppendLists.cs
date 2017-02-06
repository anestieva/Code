using System;
using System.Collections.Generic;
using System.Linq;

//  Input	                        Output
//  1 2 3 |4 5 6 |  7  8	        7 8 4 5 6 1 2 3


class AppendLists
{
    static void Main()
    {
        List<string> items = Console.ReadLine().Split('|').ToList();
        List<string> result = new List<string>();

        items.Reverse();

        foreach (var item in items)
        {
            List<string> nums = item.Split(new char[] { ' ' } , StringSplitOptions.RemoveEmptyEntries ).ToList();

            result.AddRange(nums);
        }

        Console.WriteLine(string.Join(" ", result));
    }
}