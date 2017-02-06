using System;

// Напишете програма, която намира всички прости числа в диапазона
// Решението е въз основа алгоритъма Sieve of Erathostens

class SieveOfEratosthenes
{
    static void Main()
    {
        // Вход до кое число ще принтираме простите числа
        int numbers = int.Parse(Console.ReadLine()); 
        // Булев масив, в който ще записваме кое число е просто
        bool[] prime = new bool[numbers];

        // Цикъл, с който приемаме, че всички числа са прости
        for (int i = 2; i < numbers; i++)
        {
            prime[i] = true;
        }

        // Цикъл, който ще мине по всички числа, който отговарят на условията
        for (int i = 2; i < numbers; i++)
        {
            // Ако е просто
            if (prime[i] == true)
            {
                // Променлива, с която ще обхождаме числата
                int j = i + 1;

                // Докато е по-малко от крайното число 
                while (j < numbers)
                {
                    // Ако текущото число се дели с остатък
                    if (j % i == 0)
                    {
                        // Текущото число не е просто
                        prime[j] = false;
                    }
                    // Увеличаваме текущото число и правим нова проверка
                    j++;
                }
            }
        }

        // Цикъл по всички числа
        for (int i = 2; i < numbers; i++)
        {
            // Ако са прости числа ги принтираме
            if (prime[i] == true)
            {
                Console.Write("{0} ",i);
            } 
        }
        Console.WriteLine();
    }
}