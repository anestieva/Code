using System;

//  Write a method FindNthDigit(number, index) that receives a number and an index N
//  as parameters and returns the Nth digit of the number 
//  (counted from right to left, starting from 1). 
//  After that, print the result on the console.

class nthDigit
{
    static void Main()
    {
        // Променлива за числото
        long number = long.Parse(Console.ReadLine());
        // Променлива за индекса
        int index = int.Parse(Console.ReadLine());

        // Променлива за числото на съответния индекс, която вика метод
        int nthDigit = FindNthDigit(number, index);

        // Принтира резултат
        Console.WriteLine(nthDigit);
    }

    // Метод с параметри число и индекс
    private static int FindNthDigit(long number, int index)
    {
        // Пази текущия индекс
        int currentIndex = 1;

        // Докато числото е по-голямо от нула
        while (number > 0)
        {
            // Ако текущия индекс е равен на индекса до който трябва да стигнем
            if (currentIndex == index)
            {
                // Връща делене по модул за да изкара съответното число
                return (int)(number % 10);
            }
            // Ако не сме на текущия индекс дели на 10 за да се махне последната цифра
            number /= 10;
            // Увеличава текущия индекс
            currentIndex++;
        }
        // Връща делене по модул за да изкара съответното число
        return (int)(number % 10);
    }
}