using System;
//  Write a method Encrypt(char letter) which encrypts the letter in the following way:
//  •	Take the first and the last digit of its ASCII code and append them together in a string.
//  •	Append at the start of the resulting string the character corresponding to:
//  o the ASCII code of the letter + the last digit of the ASCII code of the letter
//  •	Then append at the end of the resulting string the character corresponding to:
//  o the ASCII code of the letter - the first digit of the ASCII code of the letter
//  •	The method should return the encrypted string.

class StringEncryption
{
    static void Main()
    {
        // Чете броя символи, които ще криптираме
        var number = int.Parse(Console.ReadLine());
        // Променлива, в която ще запазваме резултата
        var result = string.Empty;

        // Цикъл, по всички символи
        for (int i = 0; i < number; i++)
        {
            // Взимаме текущия символ
            var currentChar = char.Parse(Console.ReadLine());
            // Променлива, в която с метод криптираме символа
            var encrypted = EncryptSymbol(currentChar);
            // Към резултата запазваме криптирания символ
            result += encrypted;
        }
        // Принтираме резултата
        Console.WriteLine(result);
    }

    // Метод за криптиране с параметър текущия символ
    private static string EncryptSymbol(char currentChar)
    {
        // Променлива, в която превръщаме символа в число от ASCII 
        var asciiCode = (int)(currentChar);
        // Взимаме вървото число от ASCII чрез нов метод
        var firstDigit = GetFirstDigit(asciiCode);
        // Взимаме последнното число от ASCII чрез нов метод
        var lastDigit = GetLastDigit(asciiCode);
        // За първия символ на криптация към ASCII кода добавяме последното число
        var firstSymbol = (char)(asciiCode + lastDigit);
        // За последния символ на криптация към ASCII кода изваждаме първото число
        var lastSymobol = (char)(asciiCode - firstDigit);

        // Подреждаме в резултата
        var result = ($"{firstSymbol}{firstDigit}{lastDigit}{lastSymobol}");

        // Връщаме резултата
        return result;
    }

    // Метод, с който взимаме последното число от ASCII
    private static int GetLastDigit(int asciiCode)
    {
        return (asciiCode % 10);
    }

    // Метод, с който взимаме първото число от ASCII
    private static int GetFirstDigit(int asciiCode)
    {
        // Първото число е равно на числото от ASCII
        var firstDigit = asciiCode;
        // Докато числото е по голямо от 9
        while (firstDigit > 9)
        {
            // Разделяме числото на 10, за да се маха последната цифра
            firstDigit /= 10;
        }
        // Връщаме резултата
        return firstDigit;
    }
}