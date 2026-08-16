using System;
class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Marks { get; set; }
    public Student(int id, string name, int marks )
    {
        Id = id;
        Name = name;
        Marks = marks;
    }
    public void Display()
    {
        Console.WriteLine("ID: {Id}");
        Console.WriteLine("Name:{Name}");
        Console.WriteLine("Marks:{Marks}");
        Console.WriteLine("----------------");
    }
}