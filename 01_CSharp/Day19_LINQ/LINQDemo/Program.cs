using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>
        {
        new Student { Id = 1, Name = "Mrunali", Marks = 85 },
        new Student { Id = 2, Name = "Rahul", Marks = 65 },
        new Student { Id = 3, Name = "Amit", Marks = 45 },
        new Student { Id = 4, Name = "Priya", Marks = 90 }
            };
        Console.WriteLine("Students with marks greater than 50");
        var passStudents = students.Where(s => s.Marks >= 50);
        foreach(var student in passStudents)
        {
            Console.WriteLine("Name:" + student.Name + " Marks:" + student.Marks);
        }
        Console.WriteLine();
        Console.WriteLine("Student by name");
        var names=students.OrderBy(s => s.Name).ToList();
        foreach(var name in names)
        {
            Console.WriteLine(name.Name);
        }
        Console.WriteLine();
        Console.WriteLine("Student by marks");
        var marks=students.OrderByDescending(s => s.Marks).ToList();
        foreach(var mark in marks)
        {
            Console.WriteLine(mark.Name+"-"+mark.Marks);
        }
        Console.WriteLine();
        Console.WriteLine("Total number of Students - " + students.Count());
        Console.WriteLine();
        var average=students.Average(s => s.Marks);
        Console.WriteLine("Average marks - " +average);
        Console.WriteLine();
        var max = students.Max(s => s.Marks);
        Console.WriteLine("Highest Marks:" + max);
        Console.WriteLine();
        var min = students.Min(s => s.Marks);
        Console.WriteLine("Lowest Marks:" + min);
        Console.WriteLine();
        var any = students.Any(s => s.Marks >=90);
        Console.WriteLine("Any student scored > 90 :" + any);
        Console.WriteLine();
        var first=students.First();
        Console.WriteLine("First Student - "+first.Name);
        Console.WriteLine();
        Console.WriteLine("Enter Student Name");
        string searchname=Console.ReadLine();
        var search = students.FirstOrDefault(s=>s.Name==searchname);
        if (search != null)
        {
            Console.WriteLine("Found:" + search.Name);
        }
        else
        {
            Console.WriteLine("Student not found");
        }
    }
}