using System;
using System.Collections.Generic;
using System.Linq;

namespace ExaminationSystem
{
    class Exercise1
    {
        public static void Run()
        {
            Console.WriteLine("===== Exercise 1: Student Grade Manager =====\n");

            List<int> grades = new List<int> { 85, 92, 78, 95, 88, 70, 100, 65 };

            Console.WriteLine("Grades: " + string.Join(", ", grades));
            Console.WriteLine("Count: " + grades.Count);
            Console.WriteLine("First: " + grades[0]);
            Console.WriteLine("Last: " + grades[grades.Count - 1]);

            grades.Sort();
            Console.WriteLine("\nSorted: " + string.Join(", ", grades));

            int firstAbove90 = grades.First(g => g > 90);
            Console.WriteLine("First grade above 90: " + firstAbove90);

            List<int> failing = grades.Where(g => g < 75).ToList();
            Console.WriteLine("Failing grades (below 75): " + string.Join(", ", failing));

            grades.RemoveAll(g => g < 75);
            Console.WriteLine("After removing failing grades: " + string.Join(", ", grades));

            bool has100 = grades.Contains(100);
            Console.WriteLine("Has grade 100: " + has100);

            List<string> gradeStrings = grades.Select(g => "Grade: " + g).ToList();
            Console.WriteLine("Grade strings: " + string.Join(", ", gradeStrings));
        }
    }
}
