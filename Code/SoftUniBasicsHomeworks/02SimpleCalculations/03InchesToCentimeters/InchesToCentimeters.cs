using System;

class InchesToCentimeters
{
    static void Main()
    {
        Console.Write("inches = ");
        double inches = double.Parse(Console.ReadLine());

        double result = inches * 2.54;

        Console.WriteLine("centimeters = {0}", result);
    }
}