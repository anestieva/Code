using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class DistinctList
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

        for (int i = 0; i < numbers.Count; i++)
        {
            for (int j = i+1; j < numbers.Count; j++)
            {
                if (numbers[i] == numbers[j])
                {
                    numbers.RemoveAt(j);
                    i = 0;
                }
            }
        }
        Console.WriteLine(string.Join(" ", numbers));
    }
}