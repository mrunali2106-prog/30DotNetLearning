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
            Console.WriteLine("Result :" + (n1 / n2));
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Second Number can not be zero.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Please Enter valid numbers.");
        }
    }
}