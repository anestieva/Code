using System;

//  Вход                Изход
//  10                  Yes! 5.00
//  170.00
//  6		
//
//  Обяснение
//  Първи рожден ден получава играчка; 2ри -> 10лв; 3ти -> играчка;
//  4ти -> 10 + 10 = 20лв; 5ти -> играчка; 6ти -> 20 + 10 = 30лв; 7ми -> играчка;
//  8ми -> 30 + 10 = 40лв; 9ти -> играчка; 10ти -> 40 + 10 = 50лв.
//  Спестила е -> 10 + 20 + 30 + 40 + 50 = 150лв.Продала е 5 играчки по 6 лв = 30лв.
//  Брат ѝ взел 5 пъти по 1 лев = 5лв.Остават -> 150 + 30 – 5 = 175лв.
//  175 >= 170 (цената на пералнята) успяла е да я купи и са и останали 175-170 = 5 лв.

class SmartLilly
{
    static void Main()
    {
        double lilyAge = double.Parse(Console.ReadLine());
        double price = double.Parse(Console.ReadLine());
        double toyPrice = double.Parse(Console.ReadLine());

        double money = 0;
        double toyMoney = 0;
        double bonus = 10;


        for (int i = 1; i <= lilyAge; i++)
        {
            if (i % 2 == 0)
            {
                money += bonus;
                money -=1;
                bonus += 10;

            }
            if (i % 2 != 0)
            {
                toyMoney += toyPrice;
            }
        }

        double result = money+toyMoney;

        if (result >= price)
        {
            double monySave = result - price;
            Console.WriteLine("Yes! {0:F2}", monySave);
        }
        if (result < price)
        {
            double moneyNeed = price-result;
            Console.WriteLine("No! {0:F2}", moneyNeed);
        }
    }
}