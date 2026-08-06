using System;
class Program
{
    static void Main()
    {
        double balance = 10000;
        try
        {
            Console.WriteLine("Enter WithDarwal Amount:");
            double amount = Convert.ToDouble(Console.ReadLine());
            if (amount > balance)
            {
                throw new Exception("Insufficient Balance.");
            }
            balance -= amount;
            Console.WriteLine("Remaining Balance:" + balance);
        }
        catch (FormatException)
        {
            Console.WriteLine("Please enter a valid amount");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}