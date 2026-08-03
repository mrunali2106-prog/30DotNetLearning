using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter First no:");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Second no:");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Select operation: 1.Addition 2.Subtraction 3.Multiplication 4.Division");
        int choice = Convert.ToInt32(Console.ReadLine());
        switch(choice)
        {
            case 1:
                Console.WriteLine("Result: " + (num1 + num2));
                break;
            case 2:
                Console.WriteLine("Result: " + (num1 - num2));
                break;
            case 3:
                Console.WriteLine("Result: " + (num1 * num2));
                break;
            case 4:
                if(num2 != 0)
                    Console.WriteLine("Result: " + (num1 / num2));
                else
                    Console.WriteLine("Error: Division by zero");
                break;
            default:
                Console.WriteLine("Invalid choice");
                break;
        }
}