using System;

class Bank
{
    public double Balance = 1000;

    public void Deposit(double amount)
    {
        Balance += amount;

        Console.WriteLine("Updated Balance: " + Balance);
    }

    public void Withdraw(double amount)
    {
        if (amount <= Balance)
        {
            Balance -= amount;

            Console.WriteLine("Updated Balance: " + Balance);
        }
        else
        {
            Console.WriteLine("Insufficient Balance");
        }
    }
}

class Program
{
    static void Main()
    {
        Bank b = new Bank();

        b.Deposit(500);

        b.Withdraw(300);
    }
}
