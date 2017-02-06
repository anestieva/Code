using System;

// Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5.
// Print the obtained array on the console.


class Arrays
{
    static void Main()
    {
        int lenght = int.Parse(Console.ReadLine());
        int[] array = new int[lenght];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = i * 5;
        }

        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }
    }
}