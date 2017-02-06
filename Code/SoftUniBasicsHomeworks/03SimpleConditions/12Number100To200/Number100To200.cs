using System;

class Number100To200
{
    static void Main()
    {
        double input = double.Parse(Console.ReadLine());

        if (input < 100)
        {
            Console.WriteLine("Less than 100");
        }
        else if (input > 200)
        {
            Console.WriteLine("Greater than 200");
        }
        else if (input >= 100 && input <= 200)
        {
            Console.WriteLine("Between 100 and 200");
        }
        else
        {
            Console.WriteLine("Error!");
        }
    }
}