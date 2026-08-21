class Program
{
    static void Main()
    {
        List<Student> students=new List<Student>();
        students.Add(new Student(101, "Rahul", 60));
        students.Add(new Student(102, "Priya", 85));
        students.Add(new Student(103, "Amit", 75));
        students.Add(new Student(104, "neha", 90));
        students.Add(new Student(105, "Raj", 55));
        Console.WriteLine("Display the student list where marks >=60");
        var res = students.Where(s => s.Marks >= 60);
        foreach(Student student in res)
        {
            Console.WriteLine(student.Name);
        }
        Console.WriteLine();
        Console.WriteLine("Display only Stundet names");
        var names=students.Select(s => s.Name);
        foreach(string name in names)
        {
            Console.WriteLine(name);
        }
        Console.WriteLine();
        Console.WriteLine("Highest Marks");
        Student highestStudent = students.OrderByDescending(s => s.Marks)
            .FirstOrDefault();
        Console.WriteLine("Highest Marks:" + highestStudent.Name);
        Console.WriteLine();
        Console.WriteLine("Search By ID");
        Console.WriteLine("Enter Student Id:");
        int id=Convert.ToInt32(Console.ReadLine());
        Student find=students.FirstOrDefault(s => s.Id == id);
        Console.WriteLine(find.Name);
        Console.WriteLine();
        int total=students.Count();
        Console.WriteLine("Total Students:" + total);
        var passedstudent = students.Where(s => s.Marks >= 35);
        Console.WriteLine("Passed Students:"+passedstudent.Count());
        var TotalMarks=students.Sum(s => s.Marks);
        Console.WriteLine("Total Marks:"+TotalMarks);
        var averagemarks=students.Average(s=> s.Marks);
        Console.WriteLine("Average Marks:"+averagemarks);
        var max=students.Max(s=> s.Marks);
        Console.WriteLine("Highest Marks:" + max);
        var min =students.Min(s=> s.Marks);
        Console.WriteLine("Lowest Marks:" + min);
    }
}