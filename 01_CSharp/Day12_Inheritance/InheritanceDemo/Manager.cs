using System;
class Manager: Employee
{
    public Manager(string name) : base(name)
    {
        Console.WriteLine("Manager Constructor");
    }
}