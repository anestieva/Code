using System;

class HelloName
{
    static void Main()
    {
        // Създаване на променлива
        string name = Console.ReadLine();

        // Деклариране на метод
        HelloNameMethod(name);

        // Принтиране на метод
        Console.WriteLine(HelloNameMethod(name));
    }

    // Метод приема параметър name
    static string HelloNameMethod(string name)
    {
        // Създаваме променлива, с резултата, който ще връща
        string result = "Hello" + ", " + name + "!";
        // Връщаме резултата
        return result;
    }
}