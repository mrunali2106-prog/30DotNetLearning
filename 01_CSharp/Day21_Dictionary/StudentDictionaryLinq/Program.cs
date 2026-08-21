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
        Dictionary<int, Student> students = new Dictionary<int, Student>();
            students.Add(106, new Student
            {
                Id = 106,
                Name = "Sneha",
                Marks = 88
            });
            students.Add(107, new Student
            {
                Id = 107,
                Name = "Karan",
                Marks = 72
            });
            students.Add(108, new Student
            {
                Id = 108,
                Name = "Pooja",
                Marks = 96
            });
        while(true) 
        {
        Console.WriteLine("=================================================");
        Console.WriteLine("1) Search Student");
        Console.WriteLine("2) Students Marks >=80");
        Console.WriteLine("3) Highest Marks");
        Console.WriteLine("4) Average Marks");
        Console.WriteLine("5) Sort By Marks");
        Console.WriteLine("6) Search Using TryGetValue");
        Console.WriteLine("7) Exit");
        Console.WriteLine("Enter your choice");
        int ch=Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    Console.WriteLine("Enter Student ID:");
                    int id = Convert.ToInt32(Console.ReadLine());
                    if (students.ContainsKey(id))
                    {
                        Student student = students[id];
                        Console.WriteLine("student found");
                        Console.WriteLine("ID:" + student.Id);
                        Console.WriteLine("Name:" + student.Name);
                        Console.WriteLine("Marks:" + student.Marks);
                    }
                    else
                    {
                        Console.WriteLine("Student not found");
                    }
                    break;
                case 2:
                    var result = students.Values.Where(s => s.Marks >= 80);
                    foreach (Student higheststudent in result)
                    {
                        Console.WriteLine(higheststudent.Id + "-" + higheststudent.Name + "-" + higheststudent.Marks);
                    }
                    break;
                case 3:
                    var highest = students.Values.OrderByDescending(s => s.Marks).First();
                    Console.WriteLine("Highest Student Name:" + highest.Name);
                    break;
                case 4:
                    var average = students.Values.Average(s => s.Marks);
                    Console.WriteLine("Average Marks:" + average);
                    break;
                case 5:
                    var sort = students.Values.OrderBy(s => s.Marks);
                    foreach (Student sortstudent in sort)
                    {
                        Console.WriteLine(sortstudent.Name + " - " + sortstudent.Marks);
                    }
                    break;
                case 6:
                    if (students.TryGetValue(106, out Student searchstudent))
                    {
                        Console.WriteLine("Student Found");
                        Console.WriteLine(searchstudent.Name);
                        Console.WriteLine(searchstudent.Marks);
                    }
                    else
                    {
                        Console.WriteLine("Student not found");
                    }
                    break;
                case 7:
                    Console.WriteLine("Program Ended.");
                    return;
                    
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }        
        
        }
    }
}