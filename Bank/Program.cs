using System;
using System.Globalization;

namespace Bank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double amount;
            Account account;

            Console.Write("Enter the account number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Enter the account holder: ");
            string holder = Console.ReadLine();
            Console.Write("Would you like to make an initial deposit (y/n)? ");
            char answer = char.Parse(Console.ReadLine());
            if (answer == 'y' || answer == 'Y')
            {
                Console.Write("Enter the initial deposit amount: ");
                amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                account = new Account(number, holder, amount);
            }
            else
            {
                account = new Account(number, holder);
            }

            Console.WriteLine();
            Console.WriteLine("Account details:");
            Console.WriteLine(account);

            Console.WriteLine();
            Console.Write("Enter the deposit amount: ");
            amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            if (account.Deposit(amount))
            {
                Console.WriteLine("Deposit successful");
            }
            else
            {
                Console.WriteLine("Invalid amount");
            }
            Console.WriteLine("Updated account data:");
            Console.WriteLine(account);

            Console.WriteLine();
            Console.Write("Enter the amount to withdraw: ");
            amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            if (account.Withdrawal(amount))
            {
                Console.WriteLine("Withdrawal successful");
            }
            else
            {
                Console.WriteLine("Insufficient balance or invalid amount");
            }
            Console.WriteLine("Updated account data:");
            Console.WriteLine(account);
        }
    }
}
