using System;
class Employee
{
    public int EmployeeId;
    public string EmployeeName;
    public int Salary;

    public void DisplayEmployee()
    {
        Console.WriteLine("Employee ID:" + EmployeeId);
        Console.WriteLine("Employee Name:" + EmployeeName);
        Console.WriteLine("Salary:" + Salary);
    }
}
class Program
{
    static void Main()
    {
        Employee employee = new Employee();
        employee.EmployeeId = 102;
        employee.EmployeeName = "Amit";
        employee.Salary = 45000;
        employee.DisplayEmployee();
    }
}