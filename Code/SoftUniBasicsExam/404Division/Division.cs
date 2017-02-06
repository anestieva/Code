using System;

//  Деление без остатък на:	            Числа в диапазона                           Брой числа                  Процент
//  2	                                680, 2, 600, 200, 800, 46, 128	            7	                        p1 = 7.0 / 10 * 100 = 70.00%
//  3	                                600	                                        1	                        p2 = 1 / 10 * 100 = 10.00%
//  4	                                680, 600, 200, 800, 128	                    5	                        p3 = 5 / 10 * 100 = 50.00%


class Division
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        double divideByTwo = 0;
        double divideByThree = 0;
        double divideByFour = 0;

        double presentTwo = 0;
        double presentThree = 0;
        double presentFour = 0;

        for (int i = 0; i < n; i++)
        {
            double number = double.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                divideByTwo++;
            }
            if (number % 3 == 0)
            {
                divideByThree++;
            }
            if (number % 4 == 0)
            {
                divideByFour++;
            }
        }

        presentTwo = divideByTwo / n * 100;
        presentThree = divideByThree / n * 100;
        presentFour = divideByFour / n * 100;

        Console.WriteLine("{0:F2}%", presentTwo);
        Console.WriteLine("{0:F2}%", presentThree);
        Console.WriteLine("{0:F2}%", presentFour);
    }
}