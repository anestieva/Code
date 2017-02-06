using System;

class Fibonacci
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int f0 = 1;
        int f1 = 1;

        for (int i = 0; i < n-1; i++)
        {
            int next = f0 + f1;
            f0 = f1;
            f1 = next;
        }

        Console.WriteLine(f1);
    }
}