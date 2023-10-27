using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public class encapsulation
    {
        private string accountHolder;
        private double balance;
        public encapsulation(string accountHolder, double initialBalance)
        {
            this.accountHolder = accountHolder;
            this.balance = initialBalance;
        }
        public void Deposit(double amount)
        {
            if(amount>0)
            {
                balance += amount;
                Console.WriteLine($" Deposited ${amount}.New balance: ${balance}");
            }
            else
            {
                Console.WriteLine("Invalid deposit amount.");
            }

        }
        public void Withdraw(double amount)
        {
            if(amount>0 && amount<=balance)
            {
                balance -= amount;
                Console.WriteLine("$ Withdrawn ${amount}. new balance is: ${balance}");
            }
            else
            {
                Console.WriteLine("invalid withdrawal amount");
            }
        }

        public double GetBalance()
        {
            return balance;
        }
        public string GetAccountHolder()
        {
            return accountHolder;
        }
    }
  /*  class Program
    {
        static void main(string[] args)
        {
            encapsulation account = new encapsulation("Jhon Doe", 1000.00);
            Console.WriteLine($"Account holder :{account.GetAccountHolder()}");
            Console.WriteLine($"initial balance: ${account.GetBalance()}");

            account.Deposit(500.00);
            account.Withdraw(200.00);
            Console.WriteLine("$Final balance: ${amount.Getbalance()}");

        }
    }*/
}
