using System;

public class Employee
{
	public Employee()
	{
		Console.WriteLine("Default Constructor");
	}
	public Employee(string name)
	{
		Console.WriteLine("Employee:" + name);
	}
	public Employee(string name,int age)
	{
		Console.WriteLine("Employee:" + name);
		Console.WriteLine("Age:" + age);
	}
}
