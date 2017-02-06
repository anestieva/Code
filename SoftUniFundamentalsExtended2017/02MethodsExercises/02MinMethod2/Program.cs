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

        int min = GetMin(a, b, c);

        Console.WriteLine(min);
    }

    private static int GetMin(int a, int b, int c)
    {
        if (a < b && a < c)
        {
            return a;
        }
        else if (b < a && b < c)
        {
            return b;
        }
        else
        {
            return c;
        }
    }
}