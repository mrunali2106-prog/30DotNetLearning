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

        Console.WriteLine("Students with marks greater than 70");
        var passedStudents = students.Where(s => s.Marks > 70);
        foreach(Student student in passedStudents)
        {
            Console.WriteLine(student.Name+"-"+student.Marks);
        }
        Console.WriteLine();
        Console.WriteLine("Highest Marks");
        var highest=students.Max(s=>s.Marks);
        Console.WriteLine(highest);
        Console.WriteLine();
        Console.WriteLine("Average");
        var average=students.Average(s=>s.Marks);
        Console.WriteLine(average);
        Console.WriteLine();
        Console.WriteLine("Total Students");
        int total = students.Count();
        Console.WriteLine(total);
    }
}