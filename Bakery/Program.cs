using System;
using System.Globalization;

namespace Bakery
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Clerk clerk = new Clerk();

            Console.Write("Name: ");
            clerk.Name = Console.ReadLine();
            Console.Write("Gross salary: ");
            clerk.GrossSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Tax: ");
            clerk.Tax = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Clerk: " + clerk);

            Console.WriteLine();
            Console.Write("Enter the percentage to increase the salary: ");
            double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            clerk.IncreaseSalary(percentage);

            Console.WriteLine();
            Console.Write("Updated data: " + clerk);
        }
    }
}
