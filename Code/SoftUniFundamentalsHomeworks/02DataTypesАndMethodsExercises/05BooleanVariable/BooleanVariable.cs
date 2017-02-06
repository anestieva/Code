using System;

class BooleanVariable
{
    static void Main()
    {
        string input = Console.ReadLine();

        bool result = Convert.ToBoolean(input);

        if (result)
        {
            Console.WriteLine("Yes");
        }
        else if (!(result))
        {
            Console.WriteLine("No");
        }
    }
}