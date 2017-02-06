using System;

class NumberInRange
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        while (number < 1 || number > 100)
        {
            Console.WriteLine("Invalid number!");
            number = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("The number is: {0}",number);
    }
}