using System;
using System.Linq;

//  Програма, която изчислява дали сумата на елементите от едната страна на масива за равни на сумата на елементите от другата страна.
//  Принтира се индекса
//
//  Вход                 Изход                  Обяснение
//  1 2 3 3	             2	                    At a[2] -> left sum = 3, right sum = 3
//                                              a[0] + a[1] = a[3]

class EqualSums
{
    static void Main()
    {
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

        for (int i = 0; i < numbers.Length; i++)
        {
            int leftSum = 0;
            int rightSum = 0;

            for (int j = i + 1; j < numbers.Length; j++)
            {
                rightSum += numbers[j];
            }
            for (int j = 0; j < i; j++)
            {
                leftSum += numbers[j];
            }

            if (leftSum == rightSum)
            {
                Console.WriteLine(i);
                break;
            }
        }
    }
}