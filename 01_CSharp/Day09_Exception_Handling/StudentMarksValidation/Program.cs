using System;
class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Enter Marks:");
            int marks = Convert.ToInt32(Console.ReadLine());
            if (marks < 0 || marks > 100)
            {
                throw new Exception("Marks Should be between o and 100");
            }
            Console.WriteLine("Marks=" + marks);
        }
        catch (FormatException)
        {
            Console.WriteLine("Please enter valid number");
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}