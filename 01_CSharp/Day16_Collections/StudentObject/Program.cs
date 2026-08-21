class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Marks { get; set; }
    public Student(int id, string name, int marks)
    {
        Id = id;
        Name = name;
       Marks = marks;
    }
 }
class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>();
        students.Add(new Student(1, "Rahul", 75));
        students.Add(new Student(2, "Priya", 85));
        students.Add(new Student(3, "Amit", 65));
        students.Add(new Student(4, "Jiya",65));
        students.Add(new Student(5, "Rohan", 74));
        foreach (Student student in students)
        {
            Console.WriteLine("Id:"+student.Id+", Name:"+student.Name+",Marks:"+student.Marks);
        }
    }
}

