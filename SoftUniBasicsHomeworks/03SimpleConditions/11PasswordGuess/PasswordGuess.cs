using System;

class PasswordGuess
{
    static void Main()
    {
        string input = Console.ReadLine();

        string secretPassword = "s3cr3t!P@ssw0rd";

        int result = string.Compare(input, secretPassword);

        if (result == 0)
        {
            Console.WriteLine("Welcome");
        }
        else
        {
            Console.WriteLine("Wrong password!");
        }
    }
}