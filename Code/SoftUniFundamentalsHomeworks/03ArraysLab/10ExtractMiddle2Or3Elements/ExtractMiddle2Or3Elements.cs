using System;
using System.Linq;

class ExtractMiddle2Or3Elements
{
    static void Main()
    {
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int[] extracted = ExtractMiddleElements(numbers);
       
        Console.WriteLine(string.Join(" ", extracted));
    }

    private static int[] ExtractMiddleElements(int[] numbers)
    {
        if (numbers.Length == 1)
        {
            int[] result = new int[1];
            result[0] = numbers[0];
            numbers = result;
        }
        else if (numbers.Length % 2 == 0)
        {
            int[] result = new int[2];
            result[0] = numbers[numbers.Length / 2 - 1];
            result[1] = numbers[numbers.Length / 2];
            numbers = result;
        }
        else if (numbers.Length % 2 != 0)
        {
            int[] result = new int[3];
            result[0] = numbers[numbers.Length / 2 - 1];
            result[1] = numbers[numbers.Length / 2];
            result[2] = numbers[numbers.Length / 2 + 1];
            numbers = result;
        }
        return numbers;
    }
}