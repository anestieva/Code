using System;

class Number0To100ToText
{
    static void Main()
    {
        var num = int.Parse(Console.ReadLine());
        var firstnum = num / 10;  // взема целочислената част - примерно 25/10 = 2
        var secnum = num % 10; // остатъка при деление на 10 - примерно 25%10= 5
        var bothnum = num; // Задаваме числото иначе няма да работи

        string secword = "";
        string firstword = "";
        string bothword = "";

        //Console.WriteLine(secnum);

        switch (secnum)
        {
            case 0: secword = "zero"; break;
            case 1: secword = "one"; break;
            case 2: secword = "two"; break;
            case 3: secword = "three"; break;
            case 4: secword = "four"; break;
            case 5: secword = "five"; break;
            case 6: secword = "six"; break;
            case 7: secword = "seven"; break;
            case 8: secword = "eight"; break;
            case 9: secword = "nine"; break;
            default: break;
        }

        switch (firstnum)
        {
            case 2: firstword = "twenty"; break;
            case 3: firstword = "thirty"; break;
            case 4: firstword = "fourty"; break;
            case 5: firstword = "fifty"; break;
            case 6: firstword = "sixty"; break;
            case 7: firstword = "seventy"; break;
            case 8: firstword = "eighty"; break;
            case 9: firstword = "ninety"; break;
            default: break;
        }
        switch (bothnum)
        {
            case 10: bothword = "ten"; break;
            case 11: bothword = "eleven"; break;
            case 12: bothword = "twelve"; break;
            case 13: bothword = "thirteen"; break;
            case 14: bothword = "fourteen"; break;
            case 15: bothword = "fifteen"; break;
            case 16: bothword = "sixteen"; break;
            case 17: bothword = "seventeen"; break;
            case 18: bothword = "eighteen"; break;
            case 19: bothword = "nineteen"; break;
            default: break;
        }

        if (num >= 0 && num <= 9)
        {
            Console.WriteLine(secword);
        }
        else if (num >= 10 && num <= 19)
        {
            Console.WriteLine(bothword);
        }
        else if (num >= 20 && num <= 100)
        {
            if (num % 10 == 0 && num != 10 && num != 100) // този израз описва числата 20 30 40 50 60 70 80 90 (без 10 и 100)
            {
                Console.WriteLine(firstword);
            }
            else if (num == 100)
            {
                Console.WriteLine("one hundred");
            }
            else
            {
                Console.WriteLine(firstword + " " + secword);
            }

        }
        else
        {
            Console.WriteLine("invalid number");
        }
    }
}