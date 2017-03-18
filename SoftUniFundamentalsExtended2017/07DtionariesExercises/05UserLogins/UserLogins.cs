using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class UserLogins
{
    static void Main()
    {
        // Чете входа
        string input = Console.ReadLine();

        // Декларираме речник
        Dictionary<string, string> result = new Dictionary<string, string>();

        // Променлива, която ще пази неуспешните логвания
        int logins = 0;

        // Докато командата не е login
        while (input != "login")
        {
            // Сплитваме входа
            var token = input.Split();
            // Променлива за продукта
            var user = token[0];
            // Променлива за стойността
            var password = token[token.Length - 1];

            // В речника към юзер запазваме паролата
            result[user] = password;

            // Чете следващия ред
            input = Console.ReadLine();
        }

        // Чете входа
        input = Console.ReadLine();

        // Докато входа не е end
        while (input != "end")
        {
            // Сплитваме входа
            var token = input.Split();
            // Променлива за user
            var user = token[0];
            // Променлива за password
            var password = token[token.Length - 1];

            // Ако user или паролата не съвпадат с резултата
            if (!result.ContainsKey(user) || !result.ContainsValue(password))
            {
                // Принтираме, че е неуспешно
                Console.WriteLine("{0}: login failed", user);
                // Увеличаваме броя неуспешни логвания
                logins++;
            }

            // Ако user и password съвпадат
            else
            {
                // Принтираме, че логването е успешно
                Console.WriteLine("{0}: logged in successfully", user);
            }

            // Чете входа
            input = Console.ReadLine();
        }

        // Принтираме броя неуспешни логвания
        Console.WriteLine("unsuccessful login attempts: {0}", logins);

    }
}