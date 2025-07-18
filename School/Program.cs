using System;
using System.Globalization;

namespace School
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();

            Console.Write("Enter the student's name: ");
            student.Name = Console.ReadLine();
            Console.Write("Enter the student's three grades: ");
            string[] grades = Console.ReadLine().Split(' ');
            student.Grade1 = double.Parse(grades[0], CultureInfo.InvariantCulture);
            student.Grade2 = double.Parse(grades[1], CultureInfo.InvariantCulture);
            student.Grade3 = double.Parse(grades[2], CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Final grade: " + student.FinalGrade().ToString("F2", CultureInfo.InvariantCulture));
            if(student.StudentPassing() == true)
            {
                Console.Write("Passed");
            }
            else
            {
                Console.WriteLine("Failed");
                Console.Write(student.RemainingGrade().ToString("F2", CultureInfo.InvariantCulture) + " points missing");
            }
        }
    }
}
