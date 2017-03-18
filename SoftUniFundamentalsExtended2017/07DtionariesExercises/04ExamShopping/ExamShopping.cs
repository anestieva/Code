using System;
using System.Collections.Generic;

class ExamShopping
{
    static void Main()
    {
        // Чете входа
        string input = Console.ReadLine();

        // Декларираме сортиран речник
        Dictionary<string, long> result = new Dictionary<string, long>();

        // Докато командата не е shopping time
        while (input != "shopping time")
        {
            // Сплитваме входа
            var token = input.Split();
            // Променлива за продукта
            var product = token[1];
            // Променлива за стойността
            var quantity = int.Parse(token[2]);

            // Ако продукта го има в резултата
            if (result.ContainsKey(product))
            {
                // Добавяме стойността на продукта
                result[product] += quantity;
            }
            // Ако продукта го няма в резултата
            else
            {
                // Добавяме в резултата продукта и стойността
                result.Add(product, quantity);
            }

            // Чете следващия ред
            input = Console.ReadLine();
        }

        // Чете входа
        input = Console.ReadLine();

        // Докато входа не е exam time
        while (input != "exam time")
        {
            // Сплитваме входа
            var token = input.Split();
            // Променлива за продукта
            var product = token[1];
            // Променлива за стойността на продукта
            var quantity = int.Parse(token[2]);

            // Ако продукта го няма в резултата
            if (!result.ContainsKey(product))
            {
                // Принтираме, че продукта не съществува
                Console.WriteLine($"{product} doesn't exist");
            }
            // Ако продукта го има в резултата
            else
            {
                // Ако стойността на продукта е 0
                if (result[product] == 0)
                {
                    Console.WriteLine($"{product} out of stock");
                }
                // Ако стойността на продукта е над 0
                else
                {
                    // От стойността на продукта вадим продажбите
                    result[product] -= quantity;

                    // АКо е под 0 е равно на 0
                    if (result[product] < 0)
                    {
                        result[product] = 0;
                    }
                }
            }
            // Чете входа
            input = Console.ReadLine();
        }

        // Принтиране на резултата
        foreach (var productQuantityPair in result)
        {
            var product = productQuantityPair.Key;
            var quantity = productQuantityPair.Value;

            if (quantity > 0)
            {
                Console.WriteLine($"{product} -> {quantity}");
            }
        }
    }
}