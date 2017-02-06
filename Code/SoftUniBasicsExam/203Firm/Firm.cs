using System;

//  Вход                Изход   
//  90                  Yes!2 hours left.
//  7
//  3	
//
//  Обяснения
//  За проекта са нужни 90 часа.
//  Фирмата разполага със 7 дена.
//  10% от които отиват за обучение, следователно часовете за работа са: 6.3 * 8 = 50.4 часа.
//  3 служители работят извънредно – 3 * (2 часа за 7 дена) = 42 часа.
//  Общо часове = 50.4 + 42 = 92.4 часа -> 92 часа > 90
//  Проектът може да бъде завършен на време и остават 2 часа.


class Firm
{
    static void Main()
    {
        int neededHours = int.Parse(Console.ReadLine());
        int days = int.Parse(Console.ReadLine());
        int employeeOvertime = int.Parse(Console.ReadLine());

        double hours = ((days * 0.9) * 8) + (employeeOvertime * 2 * days);

        if (hours >= neededHours)
        {
            Console.WriteLine("Yes!{0} hours left.", hours-neededHours);
        }
        else
        {
            Console.WriteLine("Not enough time!{0} hours needed.", Math.Ceiling(neededHours-hours));
        }
    }
}