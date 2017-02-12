using System;
using System.Linq;

//  Write a program to read an array of doubles, a double p, multiply each element by p and print the resulting array.
//  
//  Input                           Output
//  1.2 3.0 12.3 4.56               4.8 12 49.2 18.24
//  4	


class MultiplyAnArrayOfDoubles
{
    static void Main()
    {
        var numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
        double multiply = double.Parse(Console.ReadLine());

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] *= multiply;
        }

        Console.WriteLine(String.Join(" ", numbers));
    }
}