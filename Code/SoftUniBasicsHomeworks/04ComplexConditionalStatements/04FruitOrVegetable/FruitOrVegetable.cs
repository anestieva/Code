using System;

class FruitOrVegetable
{
    static void Main()
    {
        string input = Console.ReadLine();

        if (input == "banana" || input == "apple" || input == "kiwi" || input == "cherry" || input == "lemon" || input == "grapes")
        {
            Console.WriteLine("fruit");
        }
        else if (input == "tomato" || input == "cucumber" || input == "pepper" || input == "carrot")
        {
            Console.WriteLine("vegetable");
        }
        else
        {
            Console.WriteLine("unknown");
        }
    }
}