using System;

class Program
{
    static void Add(int n1,int n2)
    {
        Console.WriteLine("Result :" + (n1 + n2));
    }
    static void Sub(int n1, int n2)
    {
        Console.WriteLine("Result :" + (n1 - n2));
    }
    static void Mul(int n1, int n2)
    {
        Console.WriteLine("Result :" + (n1 * n2));
    }
    static void Div(int n1, int n2)
    {
        Console.WriteLine("Result :" + (n1 / n2));
    }
    static void Main()
    {
        Console.WriteLine("========Calculator===========");
        Console.WriteLine("1.Addition");
        Console.WriteLine("2.Subtraction");
        Console.WriteLine("3.Multiplication");
        Console.WriteLine("4.Division");
        Console.WriteLine("5.Exit");
        Console.WriteLine("Enter Your Choice:");
        int ch = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter first number:");
        int n1=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter second number:");
        int n2=Convert.ToInt32(Console.ReadLine());
        switch(ch)
        {
            case 1:
                Add(n1,n2);
                break;
            case 2:
                Sub(n1,n2);
                break;
            case 3:
                Mul(n1,n2);
                break;
            case 4: 
                Div(n1,n2);
                break;
            case 5:
                break;

        }
    }
}