using System;

//  Input	                                                        Output
//  one one one one two hi hi my echo last last last pi             last last last


class Last3ConsecutiveEqualStrings
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        for (int i = input.Length - 1; i >= 2; i--)
        {
            if (input[i] == input[i - 1] && input[i] == input[i - 2])
            {
                Console.WriteLine("{0} {0} {0}", input[i]);
                break;
            }
        }
    }
}