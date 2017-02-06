using System;

class NumbersToWords
{
    static void Main(string[] args)
    {

        var n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            var num = int.Parse(Console.ReadLine());

            var numbersToWords = Letterize(num);
            Console.WriteLine(numbersToWords);
        }
    }

    static string Letterize(int num)
    {
        if (num < -999)
        {
            return "too small";
        }

        if (num > 999)
        {
            return "too large";
        }

        if (Math.Abs(num).ToString().Length != 3)
        {
            return string.Empty;
        }

        var result = string.Empty;

        if (num < 0)
        {
            result += "minus ";
        }

        num = Math.Abs(num);

        var firstDigit = num;
        while (firstDigit >= 10)
        {
            firstDigit /= 10;
        }

        var firstDigitWord = DigitToWord(firstDigit);

        firstDigitWord += "-hundred";
        result += firstDigitWord;

        var lastPart = num % 100;
        var lastPartString = string.Empty;

        if (lastPart == 0)
        {
            return result;
        }

        lastPartString = DigitToTeenNumberWord(lastPart);

        if (lastPartString != string.Empty)
        {
            result += $" and {lastPartString}";
            return result;
        }

        var secondDigit = lastPart / 10 % 10;
        lastPartString = DigitToTensWord(secondDigit);

        result += $" and {lastPartString}";
        var isTeenNumber = lastPart >= 11 && lastPart <= 19;

        var lastDigit = lastPart % 10;
        var lastDigitString = string.Empty;
        if (lastDigit != 0 && !isTeenNumber)
        {
            lastDigitString = DigitToWord(lastDigit);
        }

        var space = string.Empty;
        if (lastDigit != 0 && secondDigit != 0)
        {
            space = " ";
        }

        result += $"{space}{lastDigitString}";

        return result;
    }

    static string DigitToWord(int lastDigit)
    {
        string lastDigitString;
        switch (lastDigit)
        {
            case 1:
                lastDigitString = "one";
                break;
            case 2:
                lastDigitString = "two";
                break;
            case 3:
                lastDigitString = "three";
                break;
            case 4:
                lastDigitString = "four";
                break;
            case 5:
                lastDigitString = "five";
                break;
            case 6:
                lastDigitString = "six";
                break;
            case 7:
                lastDigitString = "seven";
                break;
            case 8:
                lastDigitString = "eight";
                break;
            case 9:
                lastDigitString = "nine";
                break;
            default:
                lastDigitString = string.Empty;
                break;
        }

        return lastDigitString;
    }

    static string DigitToTensWord(int secondDigit)
    {
        string lastPartString;
        switch (secondDigit)
        {
            case 1:
                lastPartString = "ten";
                break;
            case 2:
                lastPartString = "twenty";
                break;
            case 3:
                lastPartString = "thirty";
                break;
            case 4:
                lastPartString = "fourty";
                break;
            case 5:
                lastPartString = "fifty";
                break;
            case 6:
                lastPartString = "sixty";
                break;
            case 7:
                lastPartString = "seventy";
                break;
            case 8:
                lastPartString = "eighty";
                break;
            case 9:
                lastPartString = "ninety";
                break;
            default:
                lastPartString = string.Empty;
                break;
        }

        return lastPartString;
    }

    static string DigitToTeenNumberWord(int lastPart)
    {
        string lastPartString;
        switch (lastPart)
        {
            case 11:
                lastPartString = "eleven";
                break;
            case 12:
                lastPartString = "twelve";
                break;
            case 13:
                lastPartString = "thirteen";
                break;
            case 14:
                lastPartString = "fourteen";
                break;
            case 15:
                lastPartString = "fifteen";
                break;
            case 16:
                lastPartString = "sixteen";
                break;
            case 17:
                lastPartString = "seventeen";
                break;
            case 18:
                lastPartString = "eighteen";
                break;
            case 19:
                lastPartString = "nineteen";
                break;
            default:
                lastPartString = string.Empty;
                break;
        }

        return lastPartString;
    }
}