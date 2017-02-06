using System;

//  Вход                Изход   
//  20                  19.9
//  5                   3.98
//  4
//  1
//  2	
//
//  Обяснения
//  Обща площ = 20 * 20 = 400; площ на пейката = 1 * 2 = 2
//  Площ за покриване = 400 – 2 = 398
//  Площ на плочки = 5 * 4 = 20
//  Необходими плочки = 398 / 20 = 19.9
//  Необходимо време = 19.9 * 0.2 = 3.98


class RepairOfTile
{
    static void Main()
    {
        double longOfPlace = double.Parse(Console.ReadLine());
        double widthOfTile = double.Parse(Console.ReadLine());
        double heightOfTile = double.Parse(Console.ReadLine());
        double benchWidth = double.Parse(Console.ReadLine());
        double benchHeigth = double.Parse(Console.ReadLine());

        double sumOfTile = ((longOfPlace * longOfPlace) - (benchHeigth * benchWidth)) / (widthOfTile * heightOfTile);
        double time = sumOfTile * 0.2;

        Console.WriteLine(sumOfTile);
        Console.WriteLine(time);
    }
}