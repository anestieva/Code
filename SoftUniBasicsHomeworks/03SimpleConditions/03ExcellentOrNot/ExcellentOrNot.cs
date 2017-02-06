using System;

class ExcellentOrNot
{
    static void Main()
    {
        double input = double.Parse(Console.ReadLine());

        if (input >= 5.50)
        {
            Console.WriteLine("Excellent!");
        }
        else
        {
            Console.WriteLine("Not excellent.");
        }
    }
}