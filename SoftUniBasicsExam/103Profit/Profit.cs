using System;

//  Вход                Изход   
//  21                  74.61
//  75.00
//  1.59		
//
//  Обяснения
//  1 месечна заплата = 21 * 75 = 1575 долара
//  Годишен доход = 1575*12 + 1575*2.5 = 22837.5 долара
//  Данък = 25 % от 22837.5 = 5709.375
//  Чист годишен доход = 17128.125 долара = 27233.71875 лв
//  Средна печалба на ден = 27233.71875 / 365 = 74.61 лева

class Profit
{
    static void Main()
    {
        int workDayForMonth = int.Parse(Console.ReadLine());
        double moneyPerDay = double.Parse(Console.ReadLine());
        double dollar = double.Parse(Console.ReadLine());

        double moneyPerYear = (moneyPerDay * workDayForMonth * 12) + (moneyPerDay * workDayForMonth * 2.5);
        double tax = moneyPerYear * 0.25;

        double result = ((moneyPerYear - tax) * dollar) / 365;
        Console.WriteLine("{0:f2}", result);
    }
}