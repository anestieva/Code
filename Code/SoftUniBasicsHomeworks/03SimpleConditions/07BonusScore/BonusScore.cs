using System;

class BonusScore
{
    static void Main()
    {
        double input = double.Parse(Console.ReadLine());

        double bonusScore = 0;

        if (input <= 100)
        {
            bonusScore += 5;
        }
        else if (input > 100 && input <= 1000)
        {
            bonusScore = input * 20 / 100;
        }
        else if (input > 1000)
        {
            bonusScore = input * 10 / 100;
        }


        if (input % 2 == 0)
        {
            bonusScore += 1;
        }
        if (input % 10 == 5)
        {
            bonusScore += 2;
        }

        Console.WriteLine(bonusScore);
        Console.WriteLine(bonusScore + input);
    }
}