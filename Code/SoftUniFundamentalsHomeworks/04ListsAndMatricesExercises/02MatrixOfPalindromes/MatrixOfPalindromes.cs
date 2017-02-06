using System;
using System.Collections.Generic;
using System.Linq;

//  Input               Output
//  4 6	                aaa aba aca ada aea afa
//                      bbb bcb bdb beb bfb bgb
//                      ccc cdc cec cfc cgc chc
//                      ddd ded dfd dgd dhd did

class MatrixOfPalindromes
{
    static void Main()
    {
        // Чете входа
        List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
        int rows = numbers[0];
        int cols = numbers[1];

        // Променлива, която декларира първата буква
        char outsideLetter = 'a';
        //Цикъл, с който ще обхождаме масива
        for (int row = 0; row < rows; row++)
        {
            // Промелнива, която ще пази средната буква
            char middleLetter = outsideLetter;
            // Променлива, която ще обхожда масива
            for (int col = 0; col < cols; col++)
            {
                // Принтиране на резултата
                // Console.Write("{0}{1}{0} ", outsideLetter, middleLetter);
                Console.Write("" + outsideLetter + middleLetter + outsideLetter + " ");
                // Увеличаваме средната буква
                middleLetter++;
            }
            Console.WriteLine();
            // Увеличаваме външната буква
            outsideLetter++;
        }


    }
}