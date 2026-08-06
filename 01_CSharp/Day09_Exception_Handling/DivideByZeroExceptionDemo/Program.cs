using System;
class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Enter First Number:");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number:");
            int n2 = Convert.ToInt32(Console.ReadLine());
            int result = n1 / n2;
            Console.WriteLine("Result : " + result);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error : can not divide by zero.");
        }
    }
}