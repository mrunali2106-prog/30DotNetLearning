using System;
class Manager:Employee
{
    public string Department;
    public Manager(string name,double salary,string department):base(name,salary) 
    {
        Department = department;
    }
    public void DispplayDetails()
    {
        Console.WriteLine("Manager Details");
        Console.WriteLine("----------------");
        Console.WriteLine("Name:" + Name);
        Console.WriteLine("Salary:" + Salary);
        Console.WriteLine("Department:" +Department);
    }
}