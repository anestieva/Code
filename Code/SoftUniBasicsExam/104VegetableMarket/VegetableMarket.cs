using System;

//  Вход	                Изход	
//  0.194                   101
//  19.4
//  10
//  10
//
//  Обяснения
//  Зелечуците струват – 0.194лв. * 10кг. = 1.94лв.
//  Плодовете струват – 19.4лв. * 10кг.  = 194лв.
//  Общо – 195.94лв. = 101евро


class VegetableMarket
{
    static void Main()
    {
        double vegetablesPrise = double.Parse(Console.ReadLine());
        double fruitsPrise = double.Parse(Console.ReadLine());
        int kilogramsVegetables = int.Parse(Console.ReadLine());
        int kilogramsFruits = int.Parse(Console.ReadLine());

        double result = ((vegetablesPrise * kilogramsVegetables) + (fruitsPrise * kilogramsFruits)) / 1.94;

        Console.WriteLine("{0}",result);

    }
}