using System;

// Write a program that creates an array containing all symbols from the array (a-z). 
// Read a word from the console and print the index of each of its symbols in the array.

class IndexOfsymbols
{
    static void Main()
    {
        string input = Console.ReadLine();
        char[] array = new char[26];

        for (int symbol = 0; symbol < array.Length; symbol++)
        {
            array[symbol] = (char)('a' + symbol);
        }

        foreach (char symbol in input)
        {
            Console.WriteLine(Array.IndexOf(array, symbol));
        }
    }
}