using System;

class ThreeEqualNumbers
{
    static void Main()
    {
        double firstNumber = double.Parse(Console.ReadLine());
        double secondNumber = double.Parse(Console.ReadLine());
        double thirthNumber = double.Parse(Console.ReadLine());

        if (firstNumber == secondNumber && secondNumber == thirthNumber)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}