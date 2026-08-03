using System;
class Program
{
    static void Main()
    {
        /* 1) Check Whether the number is even or odd
        Console.WriteLine("Enter a number:");
        int num = Convert.ToInt32(Console.ReadLine());
        if (num % 2 == 0)
        {
            Console.WriteLine("The Number is Even");
        }
        else
        {
            Console.WriteLine("The Number is Odd");
        } 
     ---------------------------------------------------------------------------------------------
        /* 2)Check voting Eligibility
        Console.WriteLine("Enter Your Age:");
        int age = Convert.ToInt32(Console.ReadLine());
        if(age>=18)
        {
            Console.WriteLine("You are eligible to vote.");
        }
        else
        {
            Console.WriteLine("You are not eligible to vote.");
        }
        */ /*3) Login System

        Console.WriteLine("Enter Username:");
        string username =Console.ReadLine();
        Console.WriteLine("Enter Password:");
        string password = Console.ReadLine();
        if(username=="Mrunali" && password=="1111")
        {
            Console.WriteLine("Login Successful");
        }
        else
        {
            Console.WriteLine("Invalid Username or Password");
        }*/
        /*4) Grade Calculator*/
        Console.WriteLine("Enter Your Marks:");
        int marks=Convert.ToInt32(Console.ReadLine());
        if (marks >= 90)
        {
            Console.WriteLine("Grade A");
        }
        else if (marks >= 75)
        {
            Console.WriteLine("Grade B");
        }
        else if (marks >= 50)
        {
            Console.WriteLine("Grade C");
        }
        else
        {
            Console.WriteLine("Grade F");
        } 
    }
}