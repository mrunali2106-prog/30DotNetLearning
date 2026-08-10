using System;
class Student
{
    string name;
    public Student()
    {
        Console.WriteLine("Default Constructor");
    }
    public Student(string name)
    {
        this.name = name;
    }
    public void Display()
    {
        Console.WriteLine("Student Name : " +name);
    }
}