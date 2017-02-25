using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Phone
{
    static void Main()
    {
        //  Стринг, който чете номерата
        string[] numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        //  Стринг, който чете имената
        string[] names = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        //  Стринг, който чете командите
        string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        //  Цикъл, докато командата не е равна на done
        while (input[0] != "done")
        {
            // Метод, дали комадата е call или message
            CallOrMessage(numbers, names, input);

            input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        }
    }

    // Метод, дали комадата е call или message
    private static void CallOrMessage(string[] numbers, string[] names, string[] input)
    {
        //  Ако входа е call
        if (input[0] == "call")
        {
            // Цикъл по всички имена
            for (int i = 0; i < names.Length; i++)
            {
                // Ако входа е равен на някое от имената
                if (input[1] == names[i])
                {
                    // Принтираме номера, който отговаря на името
                    Console.WriteLine("calling {0}...", numbers[i]);
                    // Метод, който сумира числата от номера
                    SumCall(numbers, i);
                }
                // Ако входа е равен на някое от номерата
                else if (input[1] == numbers[i])
                {
                    // Принтираме името, което отговаря на номера
                    Console.WriteLine("calling {0}...", names[i]);
                    // Метод, който сумира числата от номера
                    SumCall(numbers, i);
                }
            }
        }

        //  Ако входа е message
        if (input[0] == "message")
        {
            // Цикъл по всички имена
            for (int i = 0; i < names.Length; i++)
            {
                // Ако входа е равен на някое от имената
                if (input[1] == names[i])
                {
                    // Принтираме номера, който отговаря на името
                    Console.WriteLine("sending sms to {0}...", numbers[i]);
                    // Метод, който сумира числата за съобщения
                    SumMessage(numbers, i);

                }
                else if (input[1] == numbers[i])
                {
                    // Принтираме името, което отговаря на номера
                    Console.WriteLine("sending sms to {0}...", names[i]);
                    // Метод, който сумира числата за съобщения
                    SumMessage(numbers, i);
                }
            }
        }
    }

    // Метод, който сумира числата за съобщения
    private static void SumMessage(string[] numbers, int i)
    {
        // Стринг, който запазва само числата
        string phone = new string(numbers[i].Where(c => Char.IsDigit(c)).ToArray());
        // Лонг, в който парсваме числата запазени в стринга
        long DIGITS = long.Parse(phone);
        // Променлива, в която пазим сумата
        long sumOfDigit = 0;
        // Цикъл по всички парснати числа
        while (DIGITS > 0)
        {
            // Към сумата, добавяме последното число
            sumOfDigit += DIGITS % 10;
            // След като вече сме добавили последното число го махаме
            DIGITS /= 10;
        }

        // Ако сумата е четна
        if (sumOfDigit % 2 == 0)
        {
            Console.WriteLine("meet me there");
        }
        // Ако сумата е нечетна
        else
        {
            Console.WriteLine("busy");
        }
    }

    // Метод, който сумира числата за обаждане
    private static void SumCall(string[] numbers, int i)
    {
        // Стринг, който запазва само числата
        string phone = new string(numbers[i].Where(c => Char.IsDigit(c)).ToArray());
        // Лонг, в който парсваме числата запазени в стринга
        long DIGITS = long.Parse(phone);
        // Променлива, в която пазим сумата
        long sumOfDigit = 0;
        // Цикъл по всички парснати числа
        while (DIGITS > 0)
        {
            // Към сумата, добавяме последното число
            sumOfDigit += DIGITS % 10;
            // След като вече сме добавили последното число го махаме
            DIGITS /= 10;
        }

        // Ако сумата е четна
        if (sumOfDigit % 2 == 0)
        {
            // Променлива, в която пазим минути
            long minutes = sumOfDigit / 60;
            // Променлива, в която пазим секунд
            long seconds = sumOfDigit % 60;

            Console.WriteLine("call ended. duration: {0:00}:{1:00}", minutes, seconds);
        }
        // Ако сумата е нечетна
        else
        {
            Console.WriteLine("no answer");
        }
    }
}