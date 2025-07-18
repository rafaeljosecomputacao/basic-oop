using System;
using System.Globalization;

namespace CarRepairShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mechanic firstMechanic = new Mechanic();
            Mechanic secondMechanic = new Mechanic();

            Console.WriteLine("First mechanic's details:");
            Console.Write("Name: ");
            firstMechanic.Name = Console.ReadLine();
            Console.Write("Salary: ");
            firstMechanic.Salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Second mechanic's details:");
            Console.Write("Name: ");
            secondMechanic.Name = Console.ReadLine();
            Console.Write("Salary: ");
            secondMechanic.Salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double averageSalary = (firstMechanic.Salary + secondMechanic.Salary) / 2.0;
            Console.WriteLine();
            Console.Write("Average salary: " + averageSalary.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
