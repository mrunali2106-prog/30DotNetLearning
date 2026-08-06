using System;
class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Enter Salary:");
            double salary = Convert.ToDouble(Console.ReadLine());
            if (salary < 0)
            {
                throw new Exception("salary can not be negative");
            }
            Console.WriteLine("Salary=" + salary);
        }
        catch (FormatException)
        {
            Console.WriteLine("Please enter a valid salary");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}