using System;
using System.Globalization;
using System.Collections.Generic;

namespace Company
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            List<Employee> employees = new List<Employee>();

            Console.Write("How many employees will be registered? ");
            int numberEmployees = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberEmployees; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Employee #" + i + ":");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                employees.Add(new Employee(id, name, salary));
            }

            Console.WriteLine();
            Console.Write("Enter the id of the employee whose salary will be increased: ");
            int idSearchEmployee = int.Parse(Console.ReadLine());
            Employee employeeSalaryIncreased = employees.Find(employee => employee.Id == idSearchEmployee);
            if (employeeSalaryIncreased != null)
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                employeeSalaryIncreased.IncreaseSalary(percentage);
            }
            else
            {
                Console.WriteLine("This id doesn't exist");
            }

            Console.WriteLine();
            Console.WriteLine("List of employees:");
            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee);
            }
        }
    }
}
