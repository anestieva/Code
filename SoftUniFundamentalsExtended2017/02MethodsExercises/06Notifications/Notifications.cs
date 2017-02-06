using System;
class Notifications
{
    static void Main()
    {
        // Променливи
        var input = int.Parse(Console.ReadLine());
        var operation = string.Empty;
        var message = string.Empty;
        int code = 0;

        // Цикъл
        for (int i = 0; i < input; i++)
        {
            // Променлива за резултата
            string result = Console.ReadLine();

            // Ако е success
            if (result == "success")
            {
                // Промениливите са
                operation = Console.ReadLine();
                message = Console.ReadLine();
                // Извиква метод
                ShowSuccess(operation, message);
            }
            // Ако е error
            else if (result == "error")
            {
                // Променливите са 
                operation = Console.ReadLine();
                code = int.Parse(Console.ReadLine());
                // Извиква метод
                ShowError(operation, code);
            }

        }
    }
    static void ShowSuccess(string operation, string message)
    {
        Console.WriteLine($"Successfully executed {operation}.");
        Console.WriteLine("==============================");
        Console.WriteLine($"Message: {message}.");
    }
    static void ShowError(string operation, int code)
    {
        string posReason = "Invalid Client Data.";
        string negReason = "Internal System Failure.";
        if (code >= 0)
        {
            Console.WriteLine($@"Error: Failed to execute {operation}.");
            Console.WriteLine("==============================");
            Console.WriteLine($"Error Code: {code}.");
            Console.WriteLine($"Reason: {posReason}");
        }
        else
        {
            Console.WriteLine($@"Error: Failed to execute {operation}.");
            Console.WriteLine("==============================");
            Console.WriteLine($"Error Code: {code}.");
            Console.WriteLine($"Reason: {negReason}");
        }
    }

}