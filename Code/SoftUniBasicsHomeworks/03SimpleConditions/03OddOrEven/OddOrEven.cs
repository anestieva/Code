using System;

class OddOrEven
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());

        if (input % 2 == 0)
        {
            Console.WriteLine("even");
        }

        if (input % 2 !=0)
        {
            Console.WriteLine("odd");
        }
    }
}