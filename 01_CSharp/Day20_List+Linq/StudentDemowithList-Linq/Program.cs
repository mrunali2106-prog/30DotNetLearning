using System;
using System.Collections.Generic;
using System.Linq;
class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Marks { get; set; }
}
class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>();
        students.Add(new Student { Id = 1, Name = "Jagruti", Marks = 90 });
        students.Add(new Student { Id = 2, Name = "Jiya", Marks = 70 });
        students.Add(new Student { Id = 3, Name = "Komal", Marks = 65 });
        students.Add(new Student { Id = 4, Name = "Nisha" , Marks=54 });
        students.Add(new Student { Id = 5, Name = "Priya", Marks = 60 });
        var result=students.Where(s => s.Marks >=60);
        foreach(Student student in result)
        {
            Console.WriteLine(student.Name);
        }
    }
    
}