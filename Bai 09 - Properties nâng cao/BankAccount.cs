using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class BankAccount
{
    public decimal Balance { get; private set; }

    public string AccountNumber { get; protected set; }

    public string Owner { get; private set; }

    public BankAccount(string owner, string accountNumber)
    {
        Owner = owner;
        AccountNumber = accountNumber;
        Balance = 0;
    }
    public void Deposit(decimal amount)
    {
        if (amount > 0)
            Balance += amount; // Chỉ class này có thể modify
    }

}
