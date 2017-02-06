using System;

//  Create a GetMin(int a, int b) method, that returns the smaller of two numbers. 
//  Write a program that reads three numbers from the console and prints the smallest of them. 
//  Use the GetMin(…) method you just created.
//  
//  Input           Output 
//  1               1
//  2
//  3	

class MinMethod
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        int firstMin = GetMin(a, b);
        int secondMin = GetMin(firstMin, c);

        Console.WriteLine(secondMin);
    }

    private static int GetMin(int a, int b)
    {
        if (a > b)
        {
            return b;
        }
        else
        {
            return a;
        }
    }
}