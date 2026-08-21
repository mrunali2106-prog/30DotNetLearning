using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>();
        students.Add(new Student
        {
            Id=1,
            Name="Mrunali",
            Marks=85
        });
        students.Add(new Student
        {
            Id = 2,
            Name = "Rahul",
            Marks = 65
        });
        students.Add(new Student
       {
            Id=3,
            Name="Amit",
            Marks=45
        });
        Console.WriteLine("All Students");
        foreach(Student student in students)
        {
            Console.WriteLine(
                student.Id+"-"+
                student.Name+"-"+
                student.Marks);
        }
        Console.WriteLine("Students with marks >=60");
        var passedStudents = students.Where(s => s.Marks >= 60);
        foreach (Student student in passedStudents)
        {
            Console.WriteLine(student.Name);
        }
        Console.WriteLine("Total Student:" + students.Count());
    }
}