using System;
using System.Collections.Generic;

class BankingSystem
{
    class Account
    {
        public string AccountHolder { get; set; }
        public double Balance { get; set; }
    }

    static List<Account> accounts = new List<Account>();

    static void Main()
    {
        string option;
        do
        {
            Console.WriteLine("\nBank System");
            Console.WriteLine("1. Create Account");
            Console.WriteLine("2nd deposit");
            Console.WriteLine("3rd payout");
            Console.WriteLine("4. View account balance");
            Console.WriteLine("5. Exit");
            Console.Write("Choose option: ");
            option = Console.ReadLine();

            switch (option)
            {
                case "1": CreateAccount(); break;
                case "2": Deposit(); break;
                case "3": Withdraw(); break;
                case "4": DisplayBalance(); break;
            }
        } while (option != "5");
    }

    static void CreateAccount()
    {
        Console.Write("Name of account holder: ");
        string name = Console.ReadLine();

        accounts.Add(new Account { AccountHolder = name, Balance = 0 });
        Console.WriteLine("Account created.");
    }

    static void Deposit()
    {
        var account = SelectAccount();
        if (account != null)
        {
            Console.Write("Amount to deposit: ");
            double amount = double.Parse(Console.ReadLine());
            account.Balance += amount;
            Console.WriteLine($"Deposit successful. New account balance: {account.Balance} €");
        }
    }

    static void Withdraw()
    {
        var account = SelectAccount();
        if (account != null)
        {
            Console.Write("Amount to withdraw: ");
            double amount = double.Parse(Console.ReadLine());
            if (amount <= account.Balance)
            {
                account.Balance -= amount;
                Console.WriteLine($"Payout successful. New account balance: {account.Balance} €");
            }
            else
            {
                Console.WriteLine("Insufficient account balance.");
            }
        }
    }

    static void DisplayBalance()
    {
        var account = SelectAccount();
        if (account != null)
        {
            Console.WriteLine($"Account balance of {account.AccountHolder}: {account.Balance} €");
        }
    }

    static Account SelectAccount()
    {
        if (accounts.Count == 0)
        {
            Console.WriteLine("No accounts available.");
            return null;
        }

        Console.WriteLine("\nAvailable accounts:");
        for (int i = 0; i < accounts.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {accounts[i].AccountHolder}");
        }

        Console.Write("Select account number: ");
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index >= 0 && index < accounts.Count)
        {
            return accounts[index];
        }
        else
        {
            Console.WriteLine("Invalid selection.");
            return null;
        }
    }
}