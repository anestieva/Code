using System;
using System.Linq;

class SquaresInMatrix3x3
{
    static void Main()
    {
        int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int rows = input[0];
        int cols = input[1];

        int[][] matrix = new int[rows][];

        for (int row = 0; row < rows; row++)
        {
            matrix[row] = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        }

        int bestSum = 0;
        int bestRow = 0;
        int bestCol = 0;

        for (int row = 0; row < rows - 2; row++)
        {
            for (int col = 0; col < cols - 2; col++)
            {
                int sum = matrix[row][col] + matrix[row][col + 1] + matrix[row][col + 2] +
                    matrix[row + 1][col] + matrix[row + 1][col + 1] + matrix[row + 1][col + 2] +
                    matrix[row + 2][col] + matrix[row + 2][col + 1] + matrix[row + 2][col + 2];

                if (sum > bestSum)
                {
                    bestSum = sum;
                    bestRow = row;
                    bestCol = col;
                }
            }
        }
        Console.WriteLine(bestSum);

        for (int i = bestRow; i < bestRow + 3; i++)
        {
            for (int j = bestCol; j < bestCol + 3; j++)
            {
                Console.Write(matrix[i][j] + " ");
            }
            Console.WriteLine();
        }
    }
}