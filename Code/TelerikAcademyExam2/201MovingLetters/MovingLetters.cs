using System;
using System.Text;

class MovingLetters
{
    // Метод, с който обикаляме до най-дългата дума, взимаме последната буква и я записваме, като първа
    static StringBuilder ExtractLetters(string[] words)
    {
        StringBuilder result = new StringBuilder();

        // Намираме най-дългата дума
        int maxWordLenght = 0;
        for (int i = 0; i < words.Length; i++)
        {
            // Променлива за текуща дума
            string currentWord = words[i];
            // Ако най-дългата дума е по-къса от текущата
            if (maxWordLenght < currentWord.Length)
            {
                // Най-дългата дума е равна на текущата
                maxWordLenght = currentWord.Length;
            }
        }


        // Цикъл, който обикаля до най-дългата дума
        for (int i = 0; i < maxWordLenght; i++)
        {
            // Цикъл, който обикаля всички думи
            for (int j = 0; j < words.Length; j++)
            {
                // Променлива, която пази текущата дума
                string currentWord = words[j];

                // Ако текущата дума е по-голяма от i
                if (currentWord.Length > i)
                {
                    // Променлива за последната буква
                    int lastLeter = currentWord.Length - 1 - i;
                    // Записване на последната буква
                    result.Append(currentWord[lastLeter]);
                }
            }
        }
        return result;
        // Принтиране на разместените букви
        // Console.WriteLine(strangeCobination.ToString());
    }

    // Метод, който обикаля буква по буква
    static string MoveLetters(StringBuilder strangePieceOfWords)
    {
        // Цикъл по всички символи на думата
        for (int i = 0; i < strangePieceOfWords.Length; i++)
        {
            // Хващаме текущия символ и го местим, с определен брой позиции
            char curentSymbol = strangePieceOfWords[i];
            
            // Определяме броя на позициите, с които ще го преместим, като а = 1, b = 2, c = 3
            int transition = char.ToLower(curentSymbol) - 'a' + 1;

            // Намиране на следващата позиция с деление по модул
            int nextPosition = (i + transition) % strangePieceOfWords.Length;

            // Махаме от първата буква натам по един символ
            strangePieceOfWords.Remove(i, 1);

            // Добавяме буквата на определената позиция
            strangePieceOfWords.Insert(nextPosition, curentSymbol);
        }
        return strangePieceOfWords.ToString();
    }


    static void Main()
    {
        // Чете входа
        string[] words = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        // Записваме резултатът
        StringBuilder strangeCobination = ExtractLetters(words);

        // Мести буквите, с определен брой позиции

        string finalResult = MoveLetters(strangeCobination);

        Console.WriteLine(finalResult);


    }
}