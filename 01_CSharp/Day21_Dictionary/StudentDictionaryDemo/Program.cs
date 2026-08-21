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
        students.Add(1, new Student
        {
            Id = 1,
            Name = "Mrunali",
            Marks = 85
        });
        students.Add(2, new Student
        {
            Id = 2,
            Name = "Jiyanshi",
            Marks = 65
        });
        students.Add(3, new Student
        {
            Id = 3,
            Name = "Amit",
            Marks = 45
        });
        students.Add(4, new Student
        {
            Id = 4,
            Name = "Jiya",
            Marks = 60
        });
        students.Add(5, new Student
        {
           Id=5,
           Name="komal",
           Marks=80
        });
        Console.WriteLine("Enter Student Id:");
        int id = Convert.ToInt32(Console.ReadLine());
        if (students.TryGetValue(id, out Student student))
        {
            Console.WriteLine("Id:" + student.Id);
            Console.WriteLine("Name:" + student.Name);
            Console.WriteLine("Marks:" + student.Marks);

        }
        else
        {
            Console.WriteLine("not found");
        }
        if (students.ContainsKey(2))
        {
            Console.WriteLine("Found");
        }
    }
}