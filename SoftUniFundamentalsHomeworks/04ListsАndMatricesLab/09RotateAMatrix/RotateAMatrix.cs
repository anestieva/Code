using System;
using System.Collections.Generic;
using System.Linq;

//  Input                       Output
//  3
//  4
//  A B C D                     I E A
//  E F G H                     J F B
//  I J K L                     K G C
//                              L H D

class RotateAMatrix
{
    static void Main()
    {
        int rows = int.Parse(Console.ReadLine());
        int cols = int.Parse(Console.ReadLine());

        string[][] matrix = new string[rows][];

        for (int i = 0; i < rows; i++)
        {
            matrix[i] = Console.ReadLine().Split();
        }

        for (int i = 0; i < cols; i++)
        {
            for (int j = rows-1; j >= 0; j--)
            {
                Console.Write(matrix[j][i]);
            }
            Console.WriteLine();
        }
    }
}