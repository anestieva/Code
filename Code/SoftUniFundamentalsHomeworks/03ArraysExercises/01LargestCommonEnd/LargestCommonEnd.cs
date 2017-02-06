using System;

//  Прочита два масива от думи и намира дължината на най-дългия повтарящ се брой еднакви думи.
//
//  Вход                                            Изход
//  hi php java csharp sql html css js              3
//  hi php java js softuni nakov java learn


class LargestCommonEnd
{
    static void Main()
    {
        string[] array1 = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        string[] array2 = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        int minLength = Math.Min(array1.Length, array2.Length);


        int leftToTheRight = 0;
        int rightToTheLeft = 0;

        for (int i = 0; i < minLength; i++)
        {
            if (array1[i] == array2[i])
            {
                leftToTheRight++;
            }
        }

        // Върти цикъл на обратно
        for (int i = 0; i < minLength; i++)
        {
            if (array1[array1.Length - 1 - i] == array2[array2.Length - 1 - i])
            {
                rightToTheLeft++;
            }
        }

        Console.WriteLine(Math.Max(leftToTheRight, rightToTheLeft));
    }
}