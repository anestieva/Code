using System;

class SumSeconds
{
    static void Main()
    {
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        int num3 = int.Parse(Console.ReadLine());

        int sum = num1 + num2 + num3;

        int seconds = sum % 60;
        int min = sum / 60;

        Console.WriteLine("{0}:{1:00}", min, seconds);
    }
}