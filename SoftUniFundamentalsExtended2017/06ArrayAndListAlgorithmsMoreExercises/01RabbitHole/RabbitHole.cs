using System;
using System.Collections.Generic;
using System.Linq;

class RabbitHole
{
    static void Main()
    {
        // Чете входа и го сплитва
        List<string> command = Console.ReadLine().Split(' ').ToList();
        // Променлива за енергията
        int energy = int.Parse(Console.ReadLine());

        // Променлива за текущия индекс
        int currentIndex = 0;
        // Булева за бомба
        bool isDeadFromBomb = false;

        // Докато енергията е повече от 0
        while (energy > 0)
        {
            // Не е стъпил на бомба
            isDeadFromBomb = false;
            // Сплитваме по |
            string[] currentComand = command[currentIndex].Split('|');
            // Променлива за действието
            string action = currentComand[0];

            // Ако действието е RabbitHole
            if (action == "RabbitHole")
            {
                // Принтирай и прекъсни цикъла
                Console.WriteLine("You have 5 years to save Kennedy!");
                break;
            }

            // Променлива, в която ще записваме енергията
            int value = int.Parse(currentComand[1]);

            switch (action)
            {
                // Ако действието е на ляво 
                case "Left":
                    // Винаги започва от 0 ( 0 1 2 3, 0 1 2 3)
                    currentIndex = Math.Abs(currentIndex - value) % command.Count;
                    // Намаляваме енергията
                    energy -= value;
                    break;

                    //  АКо действието е на дясно
                case "Right":
                    // Превъртаме масива
                    currentIndex = (currentIndex + value) % command.Count;
                    // Намаляваме енергията
                    energy -= value;
                    break;
                    // АКо дейстивето е бобма
                case "Bomb":
                    // Махаме текущия индекс
                    command.RemoveAt(currentIndex);
                    // Зануляваме текущия индекс
                    currentIndex = 0;
                    // Намаляваме енергията
                    energy -= value;
                    // Стъпил на бомба е вярно
                    isDeadFromBomb = true;
                    break;
            }

            // Ако последната команда не е RabbitHole
            if (command[command.Count - 1] != "RabbitHole")
            {
                // Махаме последната команда
                command.RemoveAt(command.Count - 1);
            }

            // Добавяме Бомба и текущата енергия в края
            command.Add("Bomb|" + energy);
        }

        // Ако енергията е по-малко или равно на 0 и е стъпил на бомба
        if (energy <= 0 && isDeadFromBomb)
        {
            Console.WriteLine("You are dead due to bomb explosion!");
        }
        // Ако енергията е по-малко или равно на 0 и не е стъпил на бомба
        else if (energy <= 0 && !isDeadFromBomb)
        {
            Console.WriteLine("You are tired. You can't continue the mission.");
        }

    }
}