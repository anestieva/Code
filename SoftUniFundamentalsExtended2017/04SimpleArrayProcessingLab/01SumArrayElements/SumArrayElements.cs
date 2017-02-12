using System;

//  Write a program which reads an array of integers, calculates its sum and prints it.
//  The input consists of a number n (the number of elements) + n integers, each as a separate line.

class SumArrayElements
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int sum = 0;
        int[] numbersArray = new int[n];

        for (int i = 0; i < n; i++)
        {
            numbersArray[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < numbersArray.Length; i++)
        {
            sum += numbersArray[i];
        }

        Console.WriteLine(sum);
    }
}