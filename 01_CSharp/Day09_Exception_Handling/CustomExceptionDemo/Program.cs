using System;
class InvalidAgeException :Exception
{
    public InvalidAgeException(string message) : base(message)  
    {
    }
}
class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Enter Age:");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age < 18)
            {
                throw new InvalidAgeException("You must be 18 or older.");g, ,v.
            }
            Console.WriteLine("Eligible for voting.");
        }
        catch (InvalidAgeException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (FormatException)
        {
            Console.WriteLine("Please enter a valid number.");
        }
    }
}