using System;

class CurrencyConv
{
    static void Main()
    {
        var value = double.Parse(Console.ReadLine());                           //тук вземам стойността от потребителя
        var inputCurrency = Console.ReadLine();                                 //тук вземам входната валута
        var outputCurrency = Console.ReadLine();                                //вземам изходната валута

        currencyConv(value, inputCurrency, outputCurrency);                     //предните 3 данни, които взех по-горе, тук ги подавам
                                                                                // като параметри на собствен метод, функция
    }

    static void currencyConv(double value, string inputCurrency, string outputCurrency)             //тук създавам собствения си метод
                                                                                                    //с име currencyConv. Ключовата дума
                                                                                                    //с име void тук означава , че моят метод
                                                                                                    //или функция няма да връща стойност. В
                                                                                                    //скобите декларирам 3 променливи, които
                                                                                                    //методът или функцията ми ще приеме като
                                                                                                    //като входни данни. Първият параметър е от тип
                                                                                                    //double и това е стойността, която потребителят
                                                                                                    //въвежда. Вторият параметър е от тип низ(string)
                                                                                                    //и това е входната валута. Третият параметър е
                                                                                                    //изходната валута.   
    {
        var lev = 1.0;                                                              //Следващите няколко реда на променливи поставям
        var dollar = 1.79549;                                                       //курсовете на валутите.
        var euro = 1.95583;
        var pound = 2.53405;


        switch (inputCurrency)                                                  //тук проверявам каква е входната валута и според това
        {                                                                   //преобразувам въведеното от потребителя число във входната
            case "BGN":                                                     //валута.
                break;
            case "USD":
                value = (value * dollar);
                break;
            case "EUR":
                value = (value * euro);
                break;
            case "GBP":
                value = (value * pound);
                break;
            default:
                break;
        }


        switch (outputCurrency)                                                 //тук проверявам каква е изходната валута и използвам
        {                                                                      //преобразуваната по-горе потребителска стойност value
            case "BGN":                                                       // за изчисляване на изходящата валута.
                value = value / lev;
                break;
            case "USD":
                value = value / dollar;
                break;
            case "EUR":
                value = value / euro;
                break;
            case "GBP":
                value = value / pound;
                break;
            default:
                break;
        }

        Console.WriteLine(Math.Round(value, 2));                                //Тук просто изписвам получената стойност, като чрез
                                                                                // Math.Round() закръглям числото до 2 числа след
                                                                                //десетичната запетая
    }    
}