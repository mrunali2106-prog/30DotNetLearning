using System;
class Program
{
    static void Main()
    {
        List<string> employees = new List<string>();
        employees.Add("Rahul");
        employees.Add("Amit");
        employees.Add("Priya");
        employees.Add("Neha");
        Console.WriteLine("Employee List");
        foreach (string employee in employees)
        {
            Console.WriteLine(employee);
        }

    }
}