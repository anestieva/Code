using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FoldАndSum
{
    static void Main()
    {
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int k = numbers.Length / 4;

        int[] leftNumbers = numbers.Take(k).Reverse().ToArray();
        int[] rightNumbers = numbers.Reverse().Take(k).ToArray();

        int[] secondPartNumbers = numbers.Skip(k).Take(2 * k).ToArray();
        int[] firstPartNumbers = leftNumbers.Concat(rightNumbers).ToArray();

        int[] result = new int[firstPartNumbers.Length];

        for (int i = 0; i < result.Length; i++)
        {
            result[i] = secondPartNumbers[i] + firstPartNumbers[i];
        }

        Console.WriteLine(string.Join(" ", result));
    }
}
