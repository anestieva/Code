using System;

class PrintPartOfASCIITable
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        for (int i = a; i <= b; i++)
        {
            Console.Write((char)i + " ");
        }
        Console.WriteLine();
    }
}