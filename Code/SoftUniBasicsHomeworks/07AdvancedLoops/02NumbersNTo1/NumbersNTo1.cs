using System;

class NumbersNTo1
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = n; i > 0; i--)
        {
            Console.WriteLine(i);
        }
    }
}