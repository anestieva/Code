using System;
using System.Text;

class GenomeDecoder
{
    static void Main()
    {
        //Чете входа и го сплитва
        string inputFormat = Console.ReadLine();
        string[] format = inputFormat.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

        // Взима двете стойности и ги парсва в променливи
        int lettersPerLine = int.Parse(format[0]);
        int lettersPerSubsequence = int.Parse(format[1]);

        // Чете текста, който трябва да декодираме
        string encodedGenome = Console.ReadLine();

        // Създаваме стрингбилдер и викаме метод
        StringBuilder decodedGenom = DecodeGenome(encodedGenome);

        // Форматиране на резултатът (резултатът от декодирането, колко букви имаме на един ред, колко букви имаме в една подпоследователност
        PrintFormattedOutput(decodedGenom, lettersPerLine, lettersPerSubsequence);


    }

    static void PrintFormattedOutput(StringBuilder decodedGenom, int lettersPerLine, int lettersPerSubsequence)
    {
        // Броя на редовете е равен на дължината на декодираното съобщение делено на буквите да един ред
        int outputLines = (int)Math.Ceiling((double)decodedGenom.Length / lettersPerLine);
        // Броя на водещите символи преди цифрите намираме като вземем най-дългия ред
        int maxLineNumerDigits = outputLines.ToString().Length;

        // Пазим текущия резултат
        StringBuilder currentFormattedLine = new StringBuilder();
        int currentIndexInDexodedGenome = 0;
        for (int line = 1; line <= outputLines; line++)
        {
            // Намираме колко водещи интервала ще има
            string leadingIntervals = new string(' ', maxLineNumerDigits - line.ToString().Length);
            currentFormattedLine.Append(leadingIntervals);
            currentFormattedLine.Append(line);

            currentIndexInDexodedGenome = (line - 1) * lettersPerLine;

            for (int i = currentIndexInDexodedGenome; i < line * lettersPerLine; i++)
            {
                if (Math.Abs(currentIndexInDexodedGenome - i) % lettersPerSubsequence == 0)
                {
                    currentFormattedLine.Append(' ');
                }

                if (i >= decodedGenom.Length)
                {
                    break;
                }

                currentFormattedLine.Append(decodedGenom[i]);
            }

            Console.WriteLine(currentFormattedLine);
            currentFormattedLine.Clear();
        }

    }

    // Създаваме метод, който да декодира
    static StringBuilder DecodeGenome(string encodedGenome)
    {
        // Променлива, в която записваме резултатът
        StringBuilder decodedGenome = new StringBuilder();

        // Променлива, в която запазваме числата, като стрингове
        StringBuilder repeatTimesString = new StringBuilder();

        foreach (char symbol in encodedGenome)
        {
            // Ако числото е буква
            if (symbol == 'A' || symbol == 'C' || symbol == 'G' || symbol == 'T')
            {
                // Променлива за броя, който трябва да се повтаря буквата
                int repeatTimes = 1;
                // Ако дължината не е равна на 0
                if (repeatTimesString.Length != 0)
                {
                    // Броя повторения е равен на парснатите към int числа
                    repeatTimes = int.Parse(repeatTimesString.ToString());
                    // Почистваме буфера
                    repeatTimesString.Clear();
                }

                // Запизваме резултата в нов стринг (символа, броя повторения)
                string genomeSubsequence = new string(symbol, repeatTimes);
                // Добавяме резултата в decodedGenome
                decodedGenome.Append(genomeSubsequence);
            }
            // Ако е цифра, добавяме символа в стринга
            else
            {
                repeatTimesString.Append(symbol);
            }
        }
        return decodedGenome;
    }
}