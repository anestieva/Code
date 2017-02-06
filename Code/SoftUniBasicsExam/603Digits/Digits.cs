using System;

//  Вход                        Изход   
//  132	                        129 126 123
//                              120 119 121
//                              123 120 119
//                              121 123 120	
//  
//  Обяснения
//  Входното число 132 (1 +3) = 4 и(1 + 2) = 3  -> 4 реда по 3 числа на всеки ред
//  132 -> деление на 3 -> 132 - 3 = 
//  = 129 -> деление на 3 -> 129 - 3 =
//  = 126 -> деление на 3 -> 126 - 3 =
//  = 123 -> деление на 3 -> 123 - 3 = 
//  = 120 -> деление на 5 -> 120 - 1 = 
//  ..... 121 -> нито на 5, нито на 3 -> 121 + 2 = 123

class Digits
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        int n = number;
        int third = n % 10;
        n = n / 10;
        int second = n % 10;
        n = n / 10;
        int first = n % 10;

        int row = first + second;
        int col = first + third;

        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                if (number % 5 == 0)
                {
                    number = number - first;
                    Console.Write(number + " ");
                } 
                else if (number % 3 == 0)
                {
                    number = number - second;
                    Console.Write(number + " ");
                }
                else
                {
                    number = number + third;
                    Console.Write(number + " ");
                }
            }
            Console.WriteLine();
        }
    }
}