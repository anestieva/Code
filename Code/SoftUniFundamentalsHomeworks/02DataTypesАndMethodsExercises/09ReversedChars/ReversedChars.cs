using System;
using System.Text;

class ReversedChars
{
    static void Main()
    {
        StringBuilder symbol = new StringBuilder(3);
        for (int i = 0; i < 3; i++)
        {
            symbol.Append(Console.ReadLine());
        }
        string text = symbol.ToString();

        string reverse = String.Empty;
        for (int i = text.Length - 1; i > -1; i--)
        {
            reverse += text[i];
        }
        Console.WriteLine(reverse);
    }
}