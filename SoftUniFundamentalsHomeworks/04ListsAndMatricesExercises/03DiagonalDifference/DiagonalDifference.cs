using System;
using System.Linq;

class DiagonalDifference
{
    static void Main()
    {
        int rows = int.Parse(Console.ReadLine());

        int[][] matrix = new int[rows][];

        for (int i = 0; i < rows; i++)
        {
            matrix[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();
        }

        int primaryDiagonal = 0;
        int secondaryDiagonal = 0;

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < rows; col++)
            {
                if (row == col)
                {
                    primaryDiagonal += matrix[row][col];
                }

                if (col == matrix.Length - row - 1)
                {
                    secondaryDiagonal += matrix[row][col];
                }
            }
        }
        //   for (int i = 0; i < rows; i++)
        //   {
        //       for (int j = 0; j < rows; j++)
        //       {
        //           Console.Write("{0}  ", matrix[i][j]);
        //       }
        //       Console.WriteLine();
        //   }

        Console.WriteLine(Math.Abs(primaryDiagonal - secondaryDiagonal));
    }
}