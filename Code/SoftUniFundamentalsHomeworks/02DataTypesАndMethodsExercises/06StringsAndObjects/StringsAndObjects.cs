using System;
using System.Text;

class StringsAndObjects
{
    static void Main()
    {
        string firstInput = "Hello";
        string secondInput = "World";

        StringBuilder result = new StringBuilder(firstInput).Append(" ").Append(secondInput);

        Console.WriteLine(result);
    }
}