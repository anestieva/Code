using System;

class MaxMethod
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        GetMax(a, b);
    }

    private static void GetMax(int a, int b)
    {
        if (a >= b)
        {
            Console.WriteLine(a);
        }
        else
        {
            Console.WriteLine(b);
        }
    }
}