using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the number:");
        int num=Convert.ToInt32(Console.ReadLine());
        if (num > 0)
        {
            Console.WriteLine("Number is Positive.");
        }
        else
        {
            Console.WriteLine("Number is Negative");
        }
        if(num%2==0)
        {
            Console.WriteLine("Number is Even");
        }
        else
        {
            Console.WriteLine("Number is Odd");
        }
        for(int i = 1;i<=num;i++)
        {
            Console.WriteLine(i);
        }
    }
}