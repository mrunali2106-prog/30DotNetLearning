using System;
class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>();
        numbers.Add(1);
        numbers.Add(2);
        numbers.Add(3);
        numbers.Add(4);
        numbers.Add(5);
        Console.WriteLine("List of numbers");
        foreach (int i in numbers)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine();
        Console.WriteLine("After Remove one number ");
        numbers.Remove(2);
        foreach (int i in numbers)
        { 
            Console.WriteLine(i);
        }
        Console.WriteLine("Enter Number to search:");
        int searchno=Convert.ToInt32(Console.ReadLine());
        if(numbers.Contains(searchno))
        {
            Console.WriteLine("number is found");
        }
        else
        {
            Console.WriteLine("not found");
        }
    }
}