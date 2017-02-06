using System;

//  Първата задача от тази тема е да се напише конзолна програма, която въвежда възраст(десетично число) 
//  и пол(“m” или “f”) и отпечатва обръщение измежду следните:
//  •	“Mr.” – мъж(пол “m”) на 16 или повече години
//  •	“Master” – момче(пол “m”) под 16 години
//  •	“Ms.” – жена(пол “f”) на 16 или повече години
//  •	“Miss” – момиче(пол “f”) под 16 години
//  Примери:
//  вход        изход     
//  12          Miss
//  f         

class PersonalTitles
{
    static void Main()
    {
        double age = double.Parse(Console.ReadLine());
        string gender = Console.ReadLine();

        if (age >= 16)
        {
            switch (gender)
            {
                case "m": Console.WriteLine("Mr."); break;
                case "f": Console.WriteLine("Ms."); break;
                default: Console.WriteLine("Error!"); break;
            }
        }

        else if (age < 16)
        {
            switch (gender)
            {
                case "m": Console.WriteLine("Master"); break;
                case "f": Console.WriteLine("Miss"); break;
                default: Console.WriteLine("Error!"); break;
            }
        }
    }
}