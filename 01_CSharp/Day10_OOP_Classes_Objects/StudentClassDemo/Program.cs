using System;
class Student
{
    public string Name;
    public int Marks;
    public void Display()
    {
        Console.WriteLine("Student Name :" + Name);
        Console.WriteLine("Marks :"+Marks);
    }
}
class Program
{
    static void Main()
    {
        Student student = new Student();
        student.Name = "Mrunali";
        student.Marks = 85;
        student.Display();
    }
}