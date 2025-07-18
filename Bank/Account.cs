using System;
using System.Globalization;

namespace Bank
{
    internal class Account
    {
        public int Number { get; private set; }
        public string Holder { get; set; }
        public double Balance { get; private set; }

        public Account(int number, string holder)
        {
            Number = number;
            Holder = holder;
        }

        public Account(int number, string holder, double initialDeposit) : this(number, holder)
        {
            Deposit(initialDeposit);
        }

        public bool Deposit(double amount)
        {
            if (amount > 0.0)
            {
                Balance += amount;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Withdrawal(double amount)
        {
            if (amount > 0.0 && Balance >= amount)
            {
                Balance -= amount;
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return "Number: " + Number
                + ", Holder: " + Holder
                + ", Balance: $ " + Balance.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
