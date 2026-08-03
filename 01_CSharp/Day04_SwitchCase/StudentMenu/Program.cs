using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Select Menu Option:");
        Console.WriteLine("1.Show Name");
        Console.WriteLine("2.Show Roll Number");
        Console.WriteLine("3.Show Percentage");
        Console.WriteLine("4.Exit");

        int option = Convert.ToInt32(Console.ReadLine());
        switch (option)
        {
            case 1:
                Console.WriteLine("My Name is Mrunali");
                break;
            case 2:
                Console.WriteLine("Roll Number is 11");
                break;
            case 3:
                Console.WriteLine("Percentage 77.00 %");
                break;
            case 4:
                break;
            default:
                Console.WriteLine("Invalid");
                break;
        }
    }
}