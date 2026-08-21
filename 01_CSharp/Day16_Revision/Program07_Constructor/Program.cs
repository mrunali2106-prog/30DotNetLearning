class Student
{
    public Student(int Id,string Name,int Marks)
    {
        Console.WriteLine("Id:" + Id);       
        Console.WriteLine("Name :" + Name);
        Console.WriteLine("Marks:"+85);
    }
}
class Program
{
    static void Main()
    {
        Student student = new Student(101,"Rahul",85);
    }
}