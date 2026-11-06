using System;

namespace consoleApp
{
    class Students
    {
        static void Main (string[] args)
        {
            var students = new string[2];
    var grades = new int[2];

    Console.Write(students[0]);
    Console.Write(grades[0]);

    Console.Write(students[1]);
    Console.Write(grades[1]);

    students[0] = Console.ReadLine();
    grades[0] = Convert.ToInt32(Console.ReadLine());
    students[1] = Console.ReadLine();
    grades[1] = Convert.ToInt32(Console.ReadLine());
    
    foreach (var student in students)
    {
        Console.WriteLine(student);
    }

    foreach (var grade in grades)
    {
        Console.WriteLine(grade);
    }

        }
    }
}