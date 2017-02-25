using System;
using System.Linq;

class CharRotation
{
    static void Main()
    {
        string text = Console.ReadLine();
        int[] numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        string result = "";
        result = EvenOrOdd(text, numbers, result);

        Console.WriteLine(result);
    }

    private static string EvenOrOdd(string text, int[] numbers, string result)
    {
        for (int i = 0; i < text.Length; i++)
        {
            if (numbers[i] % 2 == 0)
            {
                result += (char)(text[i] - numbers[i]);
            }
            else
            {
                result += (char)(text[i] + numbers[i]);
            }
        }
        return result;
    }
}