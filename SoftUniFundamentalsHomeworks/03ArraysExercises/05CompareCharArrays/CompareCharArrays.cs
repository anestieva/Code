using System;
using System.Linq;

// Да се напише програма, която сравнява два масива от тип char лексикографски(буква по буква) 
// и проверява кой от двата е по-рано в лексикографската подредба.
//
//  Вход                        Изход
//  p e t e r                   annie
//  a n n i e                   peter




class CompareCharArrays
{
    static void Main()
    {
        char[] array1 = Console.ReadLine().Split().Select(char.Parse).ToArray();
        char[] array2 = Console.ReadLine().Split().Select(char.Parse).ToArray();

        int smallerArrayLenght = Math.Min(array1.Length, array2.Length);

        for (int i = 0; i < smallerArrayLenght; i++)
        {
            if (array1[i] != array2[i])
            {
                if (array1[i] < array2[i])
                {
                    Console.WriteLine(array1);
                    Console.WriteLine(array2);
                    break;
                }
                else
                {
                    Console.WriteLine(array2);
                    Console.WriteLine(array1);
                    break;
                }
            }
            else
            {
                Console.WriteLine(array1);
                Console.WriteLine(array2);
                break;
            }
        }      
    }
}