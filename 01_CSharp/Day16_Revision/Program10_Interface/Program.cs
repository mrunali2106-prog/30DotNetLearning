using System;
interface IPrintable
{
    void Print();
}
class Employee:IPrintable
{
    public void Print() 
    {
        Console.WriteLine("Employee details printed");
    }
}
class Student:IPrintable
{
   public void Print()
    {
        Console.WriteLine("Student details printed");
    }
}
class Program
{
    static void Main()
    {
        Employee emp = new Employee();
        emp.Print();
        Student student = new Student();
        student.Print();
    }
}