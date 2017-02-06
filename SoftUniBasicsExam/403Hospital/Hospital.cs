using System;

//  Вход                Изход   
//  4                   Treated patients: 23.
//  7                   Untreated patients: 21.	
//  27
//  9
//  1	
//  
//  Обяснения
//  1 ден: 7 прегледани и 0 непрегледани пациента за деня
//  2 ден: 7 прегледани и 20 непрегледани пациента за деня
//  3 ден: До момента прегледаните пациенти са общо 14, а непрегледаните – 20 –> Назначава се нов лекар –>
//  8 прегледани и 1 непрегледан пациент за деня
//  4 ден: 1 прегледан и 0 непрегледани пациента за деня
//  Общо: 23 прегледани и 21 непрегледани пациенти.


class Hospital
{
    static void Main()
    {
        var days = int.Parse(Console.ReadLine());

        int treatedPatients = 0;
        int untreatedPatients = 0;
        int doctors = 7;

        for (int day = 1; day <= days; day++)
        {
            int patients = int.Parse(Console.ReadLine());

            if ((day % 3 == 0) && (untreatedPatients > treatedPatients))
            {
                doctors++;
            }

            if (patients > doctors)
            {
                treatedPatients += doctors;

                untreatedPatients += patients - doctors;
            }
            else
            {
                treatedPatients += patients;
            }
        }
        Console.WriteLine("Treated patients: {0}.", treatedPatients);
        Console.WriteLine("Untreated patients: {0}.", untreatedPatients);
    }
}