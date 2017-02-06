using System;

class NumberTable
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            int current = i;
            int next = n;
            for (int j = 1; j <= n; j++)
            {
                if (current < n)
                {
                    Console.Write(current + " ");
                    current++;
                }
                else
                {
                    Console.Write(next + " ");
                    next--;
                }
            }
            Console.WriteLine();
        }
    }
}