using System;

class AnimalType
{
    static void Main()
    {
        string input = Console.ReadLine();

        switch (input)
        {
            case "dog": Console.WriteLine("mammal"); break;
            case "crocodile": Console.WriteLine("reptile"); break;
            case "tortoise": Console.WriteLine("reptile"); break;
            case "snake": Console.WriteLine("reptile"); break;
            default: Console.WriteLine("unknown"); break;
        }
    }
}