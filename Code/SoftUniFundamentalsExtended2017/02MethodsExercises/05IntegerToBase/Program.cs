using System;

//  Write a method IntegerToBase(number, toBase) that receives a number and a base as parameters 
//  and returns the number, converted to that number base. After that, print the result on the console.
//  The number will always be in base 10 and the base parameter will always be between 2 and 10.

class IntegerToBase
{
    static void Main()
    {
        // Променлива за числото
        long number = long.Parse(Console.ReadLine());
        // Променлива, в коя бройна система ще го превръщаме
        int toBase = int.Parse(Console.ReadLine());

        // Стринг за резултата
        string convertedNumber = IntToBase(number, toBase);

        // Принтираме резултата
        Console.WriteLine(convertedNumber);
    }

    // Метод, който приема числото и бройната система
    private static string IntToBase(long number, int toBase)
    {
        // Създаваме празен стринг
        string result = string.Empty;

        // Цикъл, докато числото е по-голямо от 0
        while (number > 0)
        {
            // Запазваме остатъка от делението в променлива
            long remainder = number % toBase;
            // Записваме остатъка от деление отпред на резултата
            result = remainder + result;
            // Махаме последната цифра от числото
            number /= toBase;
        }
        // Връщаме резултат
        return result;
    }
}