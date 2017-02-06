using System;
using System.Collections.Generic;
using System.Linq;

class BuildAMatrixOfLetters
{
    static void Main()
    {
        int rows = int.Parse(Console.ReadLine());
        int cols = int.Parse(Console.ReadLine());

        // Създаване на матрица
        char[][] matrix = new char[rows][];
        for (int i = 0; i < rows; i++)
        {
            matrix[i] = new char[cols];
        }

        // Запазване в променлива определена буква
        char letter = (char)(65);

        // Запълване на матрицата с букви
        for (int row = 0; row < rows - 1; row++)
        {
            for (int col = 0; col < cols - 1; col++)
            {
                matrix[row][col] = letter;
                letter++;
            }
        }

        // Принтиране на матрицата
        for (int row = 0; row < matrix.Length; row++)
        {
            for (int col = 0; col < matrix[row].Length; col++)
            {
                Console.Write("{0} ", matrix[row][col]);
            }
            Console.WriteLine();
        }
    }
}