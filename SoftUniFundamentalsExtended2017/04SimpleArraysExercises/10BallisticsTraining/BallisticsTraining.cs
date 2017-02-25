using System;
using System.Linq;

//  Input	                                                        Output
//  25 -3                                                           firing at[25, -3]
//  right 18 down 6 left -7 up 3	                                got 'em!
//  
//  150 33                                                          firing at[151, 32]
//  right 108 down 4 left -11 up 3 right 30 up 33 right 2	        better luck next time...

class BallisticsTraining
{
    static void Main()
    {
        int[] cordinates = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        string[] array = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
        int[] result = new int[2];

        for (int i = 0, j = 1; i < array.Length; i++, j++)
        {
            if (array[i] == "up")
            {
                result[1] += int.Parse(array[j]); 
            }
            else if (array[i] == "down")
            {
                result[1] -= int.Parse(array[j]);
            }
            else if (array[i] == "left")
            {
                result[0] -= int.Parse(array[j]);
            }
            else if (array[i] == "right")
            {
                result[0] += int.Parse(array[j]);
            }

        }

        if (cordinates[0] == result[0] && cordinates[1] == result[1])
        {
            Console.WriteLine("firing at [{0}, {1}]", result[0], result[1]);
            Console.WriteLine("got 'em!");
        }
        else
        {
            Console.WriteLine("firing at [{0}, {1}]", result[0], result[1]);
            Console.WriteLine("better luck next time...");
        }
    }
}