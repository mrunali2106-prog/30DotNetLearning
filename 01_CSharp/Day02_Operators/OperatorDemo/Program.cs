using System;
class Program
{
    static void Main()
    {
        ComparisonDemo obj = new ComparisonDemo();
        obj.Check();
        Console.WriteLine("Enter First Number:");
        int a=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Second Number:");
        int b =Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Addition:" + (a + b));
        Console.WriteLine("Subtraction:" + (a - b));
        Console.WriteLine("Muliplication:" + (a * b));
        Console.WriteLine("Division:" + (a / b));
        Console.WriteLine("Reminder:"+(a %b));
    }
}