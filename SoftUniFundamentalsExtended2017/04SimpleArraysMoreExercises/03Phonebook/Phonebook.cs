using System;

//  Input	                                        Output
//  0888888888 0888123456 +359886001122             Ivan -> 0888123456
//  Nakov Ivan Maria                                Maria -> +359886001122
//  Ivan
//  Maria
//  done    

class Phonebook
{
    static void Main()
    {
        string[] numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        string[] names = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        string input = Console.ReadLine();

        while (input != "done")
        {
            Phone(numbers, names, input);
            input = Console.ReadLine();
        }
    }

    private static void Phone(string[] numbers, string[] names, string input)
    {
        for (int i = 0; i < names.Length; i++)
        {
            if (input == names[i])
            {
                Console.WriteLine("{0} -> {1}", names[i], numbers[i]);
            }
        }
    }
}