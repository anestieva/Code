using System;

//  Студент трябва да пропътува n километра.Той има избор измежду три вида транспорт:
//  •	Такси.Начална такса: 0.70 лв.Дневна тарифа: 0.79 лв. / км.Нощна тарифа: 0.90 лв. / км.
//  •	Автобус.Дневна / нощна тарифа: 0.09 лв. / км.Може да се използва за разстояния минимум 20 км.
//  •	Влак.Дневна / нощна тарифа: 0.06 лв. / км.Може да се използва за разстояния минимум 100 км.
//  Напишете програма, която въвежда броя километри n и период от деня (ден или нощ) и изчислява цената на най-евтиния транспорт.


class TransportPrice
{
    static void Main()
    {
        double kilometers = double.Parse(Console.ReadLine());
        string time = Console.ReadLine();
        double result = 0;

        if (kilometers < 20)
        {
            switch (time)
            {
                case "day": result = 0.70 + (0.79 * kilometers); break;
                case "night": result = 0.70 + (0.90 * kilometers); break;
            }
        }
        else if (kilometers >= 20 && kilometers < 100)
        {
            switch (time)
            {
                case "day": result = 0.09 * kilometers; break;
                case "night": result = 0.09 * kilometers; break;
            }
        }
        else
        {
            switch (time)
            {
                case "day": result = 0.06 * kilometers; break;
                case "night": result = 0.06 * kilometers; break;
            }
        }
        Console.WriteLine(result);
    }
}