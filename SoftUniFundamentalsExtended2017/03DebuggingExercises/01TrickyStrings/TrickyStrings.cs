using System;
using System.Text;

class TrickyStrings
{
    static void Main()
    {
        string symbol = Console.ReadLine();
        int number = int.Parse(Console.ReadLine());
        StringBuilder result = new StringBuilder();

        for (int i = 0; i < number; i++)
        {
            string currentWord = Console.ReadLine();
            result.Append(currentWord).Append(symbol);

        }
        result.Remove(result.Length - 1, symbol.Length);
        Console.WriteLine(result);
    }
}