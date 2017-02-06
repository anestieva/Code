using System;

//  Вход            Изход   
//  1               30 24 18 12 6
//  30
//  15
//
//  Обяснения
//  Числата от 30 до 1, които се делят едновременно на 2 и на 3 без остатък са: 30, 24, 18, 12 и 6.
//  Като 15 не е равно на нито едно, затова поредицата продължава.


class StopNumber
{
    static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        int stopNumber = int.Parse(Console.ReadLine());

        int currentNumber = 0;


        for (int i = secondNumber; i >= firstNumber; i--)
        {
            if (i % 2 == 0 && i % 3 == 0)
            {
                currentNumber = i;
                if (currentNumber == stopNumber)
                {
                    break;
                }       
                Console.Write("{0} ", i);
            }
        }
        Console.WriteLine();
    }
}