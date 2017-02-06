using System;

//  Вход            Изход
//  1000            Yes! You have 0.01 leva left.
//  Normal
//  1		   30000
//
//  Обяснения
//  1 човек: 75% от бюджета отиват за транспорт
//  Остават: 1000 – 750 = 250
//  Категория Normal: билета(ът) струва 249.99 * 1
//  249.99 < 250: остават му 250 – 249.99 = 0.01

class MatchTickets
{
    static void Main()
    {
        double money = double.Parse(Console.ReadLine());
        string type = Console.ReadLine();
        int people = int.Parse(Console.ReadLine());
        double totalMoney = double.MinValue;

        double ticket = 0;


        if (type == "VIP")
        {
            ticket = people * 499.99;

            if (people >= 1 && people <= 4)
            {
                totalMoney = money - (money * 75 / 100);
            }
            else if (people >= 5 && people <= 9)
            {
                totalMoney = money - (money * 60 / 100);
            }
            else if (people >= 10 && people <= 24)
            {
                totalMoney = money - (money * 50 / 100);
            }
            else if (people >= 25 && people <= 49)
            {
                totalMoney = money - (money * 40 / 100);
            }
            else if (people >= 50)
            {
                totalMoney = money - (money * 25 / 100);
            }
        }

        if (type == "Normal")
        {
            ticket = people * 249.99;

            if (people >= 1 && people <= 4)
            {
                totalMoney = money - (money * 75 / 100);
            }
            else if (people >= 5 && people <= 9)
            {
                totalMoney = money - (money * 60 / 100);
            }
            else if (people >= 10 && people <= 24)
            {
                totalMoney = money - (money * 50 / 100);
            }
            else if (people >= 25 && people <= 49)
            {
                totalMoney = money - (money * 40 / 100);
            }
            else if (people >= 50)
            {
                totalMoney = money - (money * 25 / 100);
            }
        }


    
        if (ticket > totalMoney)
        {
            double notEnough = ticket - totalMoney;
            Console.WriteLine("Not enough money! You need {0:F2} leva.", notEnough);
        }

        else
        {
            double left = totalMoney - ticket;
            Console.WriteLine("Yes! You have {0:F2} leva left.", left);
        }
    }
}