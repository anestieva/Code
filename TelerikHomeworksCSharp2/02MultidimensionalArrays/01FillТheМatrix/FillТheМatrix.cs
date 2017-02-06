using System;
using System.Text;

class FillТheМatrix
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string symbol = Console.ReadLine();
        int counter = 1;
        int[,] matrix = new int[n, n];


        // 1   5   9   13
        // 2   6   10  14
        // 3   7   11  15
        // 4   8   12  16

        if (symbol == "a")
        {
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    matrix[col, row] = counter;
                    counter++;
                }
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (col == 0)
                    {
                        Console.Write(matrix[row, col]);
                        col++;
                    }
                    Console.Write(" " + matrix[row, col]);
                }
                Console.WriteLine();
            }
        }

        //   1  8  9 16
        //   2  7 10 15
        //   3  6 11 14
        //   4  5 12 13

        if (symbol == "b")
        {
            for (int row = 0; row < n; row++)
            {
                if (row % 2 == 0)
                {
                    for (int col = 0; col < n; col++)
                    {
                        matrix[col, row] = counter;
                        counter++;
                    }
                }
                else
                {
                    for (int col = n - 1; col >= 0; col--)
                    {
                        matrix[col, row] = counter;
                        counter++;
                    }
                }
            }
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (col == 0)
                    {
                        Console.Write(matrix[row, col]);
                        col++;
                    }
                    Console.Write(" " + matrix[row, col]);
                }
                Console.WriteLine();
            }
        }

        //  11 16 20 23 25
        //   7 12 17 21 24
        //   4  8 13 18 22
        //   2  5  9 14 19
        //   1  3  6 10 15

        if (symbol == "c")
        {
            int rows = 0;
            int cols = 0;

            for (int i = n - 1; i >= 0; i--)
            {
                rows = i;
                cols = 0;
                while (rows < n && cols < n)
                {
                    matrix[rows++, cols++] = counter++;
                }
            }

            for (int j = 1; j < n; j++)
            {
                rows = j;
                cols = 0;
                while (rows < n && cols < n)
                {
                    matrix[cols++, rows++] = counter++;
                }
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (col == 0)
                    {
                        Console.Write(matrix[row, col]);
                        col++;
                    }
                    Console.Write(" " + matrix[row, col]);
                }
                Console.WriteLine();
            }
        }

        //   1   12  11  10
        //   2   13  16  9
        //   3   14  15  8
        //   4   5   6   7

        if (symbol == "d")
        {
            string direction = "down";
            int rows = 0;
            int cols = 0;

            for (int i = 1; i <= n * n; i++)
            {
                if (direction == "down" && (rows < 0 || matrix[rows, cols] != 0))
                {
                    rows--;
                    cols--;
                    direction = "right";
                }

                else if (direction == "right" && (cols < 0 || matrix[rows, cols] != 0))
                {
                    cols--;
                    rows++;
                    direction = "up";
                }

                else if (direction == "up" && (rows >= n || matrix[rows, cols] != 0))
                {
                    rows++;
                    cols++;
                    direction = "left";
                }

                else if (direction == "left" && (cols >= n || matrix[rows, cols] != 0))
                {
                    rows--;
                    cols++;
                    direction = "down";
                }

                matrix[rows, cols] = i;

                if (direction == "down")
                {
                    rows++;
                }
                else if (direction == "right")
                {
                    cols++;
                }
                else if (direction == "up")
                {
                    rows--;
                }
                else if (direction == "left")
                {
                    cols--;
                }
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (col == 0)
                    {
                        Console.Write(matrix[row, col]);
                        col++;
                    }
                    Console.Write(" " + matrix[row, col]);
                }
                Console.WriteLine();
            }

        }






        //   1  2  3  4
        //  12 13 14  5
        //  11 16 15  6
        //  10  9  8  7

        if (symbol == "f")
        {
            string direction = "right";
            int rows = 0;
            int cols = 0;

            for (int i = 1; i <= n * n; i++)
            {
                if (direction == "right" && (cols >= n || matrix[rows, cols] != 0))
                {
                    cols--;
                    rows++;
                    direction = "down";
                }
                else if (direction == "down" && (rows >= n || matrix[rows, cols] != 0))
                {
                    rows--;
                    cols--;
                    direction = "left";
                }
                else if (direction == "left" && (cols < 0 || matrix[rows, cols] != 0))
                {
                    rows--;
                    cols++;
                    direction = "up";
                }
                else if (direction == "up" && (rows < 0 || matrix[rows, cols] != 0))
                {
                    rows++;
                    cols++;
                    direction = "right";
                }

                matrix[rows, cols] = i;

                if (direction == "right")
                {
                    cols++;
                }
                else if (direction == "down")
                {
                    rows++;
                }
                else if (direction == "left")
                {
                    cols--;
                }
                else if (direction == "up")
                {
                    rows--;
                }
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (col == 0)
                    {
                        Console.Write(matrix[row, col]);
                        col++;
                    }
                    Console.Write(" " + matrix[row, col]);
                }
                Console.WriteLine();
            }
        }


        //    1  2  3  4
        //    5  6  7  8
        //    9 10 11 12
        //   13 14 15 16

        if (symbol == "g")
        {
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = counter;
                    counter++;
                }
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (col == 0)
                    {
                        Console.Write(matrix[row, col]);
                        col++;
                    }
                    Console.Write(" " + matrix[row, col]);
                }
                Console.WriteLine();
            }
        }









        // 16 15 14 13
        // 5  4  3 12
        // 6  1  2 11
        // 7  8  9 10

        if (symbol == "e")
        {
            string direction = "right";
            int currentRow = 0;
            int currentCol = 0;

            for (int i = n * n; i > 0; i--)
            {
                if (direction == "right" && (currentCol >= n || matrix[currentRow, currentCol] != 0))
                {
                    currentCol--;
                    currentRow++;
                    direction = "down";
                }
                else if (direction == "down" && (currentRow >= n || matrix[currentRow, currentCol] != 0))
                {
                    currentRow--;
                    currentCol--;
                    direction = "left";
                }
                else if (direction == "left" && (currentCol < 0 || matrix[currentRow, currentCol] != 0))
                {
                    currentRow--;
                    currentCol++;
                    direction = "up";
                }
                else if (direction == "up" && (currentRow < 0 || matrix[currentRow, currentCol] != 0))
                {
                    currentRow++;
                    currentCol++;
                    direction = "right";
                }

                matrix[currentRow, currentCol] = i;

                if (direction == "right")
                {
                    currentCol++;
                }
                else if (direction == "down")
                {
                    currentRow++;
                }
                else if (direction == "left")
                {
                    currentCol--;
                }
                else if (direction == "up")
                {
                    currentRow--;
                }
            }

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (col == 0)
                    {
                        Console.Write(matrix[row, col]);
                        col++;
                    }
                    Console.Write(" " + matrix[row, col]);
                }
                Console.WriteLine();
            }

        }
    }
}