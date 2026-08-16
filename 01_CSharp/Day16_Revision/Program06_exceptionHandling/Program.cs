using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter your age:");
        string strage = Console.ReadLine();
        try
        {
            int age=Convert.ToInt32(strage) ;
            Console.WriteLine("Successfully enter age");
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Invalid input.Please enter a number only.");
        }

    }
}