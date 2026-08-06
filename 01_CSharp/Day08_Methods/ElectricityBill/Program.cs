using System;
class Program
{
    static int CalculateBill(int units)
    {
        return units * 6;
    }
    static void Main()
    {
        Console.WriteLine("Enter Customer Name:");
        string name = Console.ReadLine();
        Console.WriteLine("Enter units:");
        int units =Convert.ToInt32(Console.ReadLine());
        double bill =CalculateBill(units);
        Console.WriteLine("Customer name :" + name);
        Console.WriteLine("Units :" + units);
        Console.WriteLine("Electricity Bill :" + bill);
    }
}