using System;

class FibonacciNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i <= n; i++)
        {
            Console.WriteLine(Fibonacci(i));
        }
    }

    public static int Fibonacci(int n)
    {
        int a = 0;
        int b = 1;
        // In N steps compute Fibonacci sequence iteratively.
        for (int i = 0; i <= n; i++)
        {
            int temp = a;
            a = b;
            b = temp + b;
        }
        return a;
    }   
}