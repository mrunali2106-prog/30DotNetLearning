using System;

class Student
{
    public string ?Name;
    public int Age;
}
class Program
{
    static void Main()
    {
        Student student = new Student();
        student.Name = "Mrunali";
        student.Age = 31;
        Console.WriteLine("Student Name:"+student.Name);
        Console.WriteLine("Age:" + student.Age);    
    }
}