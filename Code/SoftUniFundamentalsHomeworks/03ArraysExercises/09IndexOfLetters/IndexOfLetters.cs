using System;
using System.Linq;

//  Програма, която чете масив от букви и принтира номера им в азбуката
//
//  Вход            Изход
//  abcz        	a -> 0
//                  b -> 1
//                  c -> 2
//                  z -> 25


class IndexOfLetters
{
    static void Main()
    {
        char[] input = Console.ReadLine().ToLower().Split().Select(char.Parse).ToArray();
        int[] letterToNumber = new int[input.Length];

        for (int i = 0; i < input.Length; i++)
        {
            letterToNumber[i] = (int)(input[i] - 'a');
        }

        for (int i = 0; i < input.Length; i++)
        {
            Console.WriteLine("{0} -> {1}", input[i], letterToNumber[i]);
        }
    }
}