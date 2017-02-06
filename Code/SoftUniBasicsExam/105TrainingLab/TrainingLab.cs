using System;

//  Вход            Изход    
//  15              129
//  8.9		 	
//
//  Обяснения
//  Залата е широка 890 cm.От тях 100 cm отиват за коридора в средата.В останалите 790 cm могат да се разположат по 11 бюра на ред 
//  (11 * 70 cm =    770/ cm /+ 20 cm остатък).
//  Залата е дълга 1500 cm.В тях могат да бъдат разположени 12 реда(12 * 120 cm = 1440 + 60 cm остатък).
//  Брой места = 12 * 11 - 3 = 132 - 3 = 129(имаме 12 реда по 11 места = 132 минус 3 места за катедра и входна врата).


class TrainingLab
{
    static void Main()
    {
        double width = double.Parse(Console.ReadLine());
        double heigh = double.Parse(Console.ReadLine());

        int row = (int)Math.Ceiling(((double)(heigh * 100) - 100)) / 70;
        int col = (int)Math.Ceiling((double)(width * 100)) / 120;

        int result = row * col - 3;

        Console.WriteLine(result);
    }
}