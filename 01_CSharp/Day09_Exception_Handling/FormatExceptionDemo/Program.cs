using System;
class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Enter your Age:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Age :" + age);
        }
        catch (FormatException)
        {
            Console.WriteLine("Please enter numbers only");
        }
    }
}