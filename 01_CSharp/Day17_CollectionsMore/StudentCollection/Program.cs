class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int  Marks { get; set; }
    public Student(int id, string name, int marks )
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
        students.Add(new Student(1,"Jiyanshi",90));
        students.Add(new Student(2, "Dishu", 95));
        students.Add(new Student(3, "Dhyanda", 80));
        students.Add(new Student(4, "Rishi", 75));
        students.Add(new Student(5,"khushi",60));
        Console.WriteLine("Enter Student Id:");
        int id=Convert.ToInt32(Console.ReadLine());
        bool found= false;
        foreach(Student student in students)
        {
            if(student.Id == id)
            {
                Console.WriteLine("Student Found");
                Console.WriteLine("Name:"+student.Name);
                Console.WriteLine("Marks:"+student.Marks);
                found = true;
                break;
            }
        }
        if(!found)
        {
            Console.WriteLine("Student not found");
        }

    }
}