using System;

class GreedyDwarf
{
    static void Main()
    {
        // Масив, който чете входа и сплитва
        string[] rawNumbers = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

        // Масив от int, в който сме парснали входа
        int[] vallyNumbers = new int[rawNumbers.Length];
        for (int i = 0; i < vallyNumbers.Length; i++)
        {
            vallyNumbers[i] = int.Parse(rawNumbers[i]);
        }

        // Чете колко схеми ще има
        int numberOfPatterns = int.Parse(Console.ReadLine());
        long bestSum = long.MinValue;

        // Цикъл до броя схеми, в който ще парснем видовете
        for (int i = 0; i < numberOfPatterns; i++)
        {
            long sum = ProccessPattern(vallyNumbers);

            // Запазваме най-добрата сума
            if (sum > bestSum)
            {
                bestSum = sum;
            }
        }
        Console.WriteLine(bestSum);
    }


    private static long ProccessPattern(int[] vally)
    {
        // Масив, който чете входа и сплитва
        string[] rawNumbers = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
        int[] pattern = new int[rawNumbers.Length];

        for (int i = 0; i < pattern.Length; i++)
        {
            pattern[i] = int.Parse(rawNumbers[i]);
        }

        // Булев масив, който записва дали сме били вече на тази позиция
        bool[] vissited = new bool[vally.Length];
        // Променлива, която запазва сумата
        long coinSum = 0;
        // Съм сумата добавяме текущата
        coinSum += vally[0];
        // Ако е посетена позицията
        vissited[0] = true;
        int currentPosition = 0;

        while (true)
        {
            // Цилъл по дължината
            for (int i = 0; i < pattern.Length; i++)
            {
                // Промелнива за следващия ход
                int nexMove = currentPosition + pattern[i];
                // Ако следващия ход е по-голям от нула и по-малък от дължината и не е посетен
                if (nexMove >= 0 && nexMove < vally.Length && !vissited[nexMove])
                {
                    // Към сумата, добавяме текущата сума
                    coinSum += vally[nexMove];
                    // Променяме, че е посетена позиция
                    vissited[nexMove] = true;
                    // Променяме текущата позиция да е следващата
                    currentPosition = nexMove;
                }
                // Ако сме извън масива или вече сме били на тази позиция
                else
                {
                    // Връщаме сумата
                    return coinSum;
                }
            }
        }
        return 0;
    }
}