using System;
class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>();
        students.Add(new Student(101, "Rahul", 75));
        students.Add(new Student(102, "Priya", 85));
        students.Add(new Student(103, "Amit", 65));
        foreach (Student student in students)
        {
            Console.WriteLine(student.Id + "-" + student.Name + "-" + student.Marks);
        }
    }
}