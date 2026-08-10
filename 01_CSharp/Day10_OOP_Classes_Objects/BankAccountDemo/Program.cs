using System;
class BankAccount
{
    public string AccountHolder;
    public double Balance;
    public void ShowBalance()
    {
        Console.WriteLine("Balance :" + Balance);
    }
}
class Program
{
    static void Main()
    {
        BankAccount account = new BankAccount();
        account.AccountHolder = "Mrunali";
        account.Balance = 15000;
        Console.WriteLine("Account Holder:"+account.AccountHolder);
        account.ShowBalance();
    }
}