using HomeWork_Day03;
using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter any number");
        int num = Convert.ToInt32(Console.ReadLine());
        if (num >= 0)
        {
            Console.WriteLine("The number is positive");
        }
        else
        {
            Console.WriteLine("The number is negative");
        }
        LargestNumber largestNumber = new LargestNumber();
        largestNumber.LagrestNum();

        EmployeeBonus employeeBonus = new EmployeeBonus();  
        employeeBonus.EmployessBonus();

        StudentPassorFail studentPassorFail = new StudentPassorFail();  
        studentPassorFail.StudentResult();  
    }
}
