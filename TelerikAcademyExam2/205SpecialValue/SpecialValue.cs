using System;

// Не работи

class SpecialValue
{
    static void Main()
    {
        // Чете броя редове
        int n = int.Parse(Console.ReadLine());
        // Създава назъбен масив
        int[][] field = new int[n][];
        // Метод, който запълва назъбен масив
        ReadData(field);

        // Булев масив, който пази дали сме били в определена клетка
        bool[][] visited = new bool[n][];

        // Запълваме булевата с false
        for (int i = 0; i < n; i++)
        {
            visited[i] = new bool[field[i].Length];
        }

        // Запазваме максималната стойност
        long max = long.MinValue;

        // Цикъл, който да обикаля колоните и да извиква метод
        for (int i = 0; i < field[0].Length; i++)
        {
            // Метод (поле, колона, посетен)
            long specialValue = FindCurrentSpecialValue(field, i, visited);

            if (max<specialValue)
            {
                max = specialValue;

            }

        }
        Console.WriteLine(max);
    }

    // Метод,
    static long FindCurrentSpecialValue(int[][] field, int column, bool[][] visited)
    {
        long result = 0;
        int currentRow = 0;

        while (true)
        {
            currentRow++;
            // Ако текущия ред и колона са посетени
            if (visited[currentRow][column])
            {
                return long.MinValue;
            }
            // Ако сме на отрицателно число
            if (field[currentRow][column] < 0)
            {
                // Към резултатът трябва да добавим абсолютната стойност
                result -= Math.Abs(field[currentRow][column]);
                return result;
            }

            // Ако не отговаря на предните две условия минава на следващия ред
            // Следващата колона е равна на числото от текущата
            int nextColumn = field[currentRow][column];
            // Отбелязваме, че вече е посетено
            visited[currentRow][column] = true;
            column = nextColumn;

            // Ако реда излезе от масива
            if (currentRow == field.GetLength(0))
            {
                // Текущия ред трябва да се върне на 0
                currentRow = 0;
            }
            result++;
        }
    }

    // Метод, който запълва назъбен масив
    static int[][] ReadData(int[][] field)
    {
        // Цилъл по всички редове
        for (int i = 0; i < field.GetLength(0); i++)
        {
            // Променлива за дължината на колоните
            string[] currentLine = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            // Запълваме редовете с дължината на колоните
            field[i] = new int[currentLine.Length];

            // Цикъл, който запълва стойностите в масива
            for (int l = 0; l < currentLine.Length; l++)
            {
                field[i][l] = int.Parse(currentLine[l]);
            }
        }
        return field;
    }
}