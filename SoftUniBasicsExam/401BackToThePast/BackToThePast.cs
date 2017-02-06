using System;

//  Вход                Изход
//  50000               Yes! He will live a carefree life and will have 13050.00 dollars left.  
//  1802	
//
//  Обяснение
//  1800 → четна
//           → Харчи 12000 лева
//           → Остават 50000 – 12000 = 38000
//  1801 → нечетна
//           → Харчи 12000 + 19*50 = 12000 + 950 = 12950
//           → Остават 38000 – 12950 = 25050
//  1802 → четна
//           → Харчи 12000 лева
//           → Остават 25050 – 12000 = 13050


class BackToThePast
{
    static void Main()
    {
        double money = double.Parse(Console.ReadLine());
        int endYear = int.Parse(Console.ReadLine());

        int startYear = 1800;
        int startAge = 18;


        for (int i = startYear; i <= endYear; i++)
        {

            if (i % 2 == 0)
            {
                money = money - 12000;
            }
            if (i % 2 != 0)
            {
                money = money - (12000 + (startAge * 50));
            }
            startAge++;
        }


        if (money >= 0)
        {
            Console.WriteLine("Yes! He will live a carefree life and will have {0:F2} dollars left.", money);
        }

        else
        {
            // Math.Abs => Абсолютна стойност от отрицателно в положително
            Console.WriteLine("He will need {0:F2} dollars to survive.", Math.Abs(money));
        }
    }
}