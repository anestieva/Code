using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class AverageStudentGrades
{
    static void Main()
    {
        // Чете броя редове
        var n = int.Parse(Console.ReadLine());
        // Създаване на речник
        var grades = new Dictionary<string, List<double>>();

        // Цикъл до броя редове
        for (int i = 0; i < n; i++)
        {
            // Променлива, която сплитва входа
            var nameAndGrade = Console.ReadLine().Split(' ');
            // Променлива за името
            var name = nameAndGrade[0];
            // Променлива за оценката
            var grade = double.Parse(nameAndGrade[1]);

            // Ако името не се съдържа в речника
            if (!grades.ContainsKey(name))
            {
                // Създай нов лист с това име
                grades[name] = new List<double>();
            }
            // Добави оценките към това име
            grades[name].Add(grade);

        }

        // Принтиране на резултата
        foreach (var nameAndGrades in grades)
        {
            Console.WriteLine("{0} -> {1} (avg: {2:f2})", 
                // Принтирай имената
                nameAndGrades.Key,
                //  Принтирай форматиран на стринг към 0:00 с всички оценки
                string.Join(" ", nameAndGrades.Value.Select(p => string.Format("{0:f2}", p))),
                // Принтирай средно аритметичната стойност на оценките 
                nameAndGrades.Value.Average());
        }
    }
}