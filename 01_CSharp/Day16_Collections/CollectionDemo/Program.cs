class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>();
        students.Add(new Student(1, "Rahul", 75));
        students.Add(new Student(2,"Priya",85));
        students.Add(new Student(3, "Amit", 65));

        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("=======================================");
            Console.WriteLine("           Student Management ");
            Console.WriteLine("1.Display Students");
            Console.WriteLine("2.Search Student");
            Console.WriteLine("3.Remove Student");
            Console.WriteLine("4.Total Students");
            Console.WriteLine("5.Add Students");
            Console.WriteLine("6.Exit");
            Console.WriteLine("========================================");
            Console.WriteLine("Enter your choice:");
            try
            {
                int choice = Convert.ToInt32(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        Console.WriteLine("Student List:");
                        foreach (Student student in students)
                        {
                            Console.WriteLine("ID:" + student.Id+", Name:"+student.Name+", Marks:"+student.Marks);
                        }
                        break;
                    case 2:
                        Console.WriteLine("Enter Student Id:");
                        int searchId=Convert.ToInt32(Console.ReadLine());
                        bool found = false;
                        foreach (Student student in students)
                        {
                            if (student.Id == searchId)
                            {
                                Console.WriteLine("Student Found:"+student.Name+"-Marks:"+student.Marks);
                                found = true;
                                break;
                            }
                        }
                        if (!found)
                        {
                            Console.WriteLine("Student Not Found");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Enter Student Id to Remove:");
                        int removeId= Convert.ToInt32(Console.ReadLine());
                        Student studentToRemove = null;
                        foreach (Student student in students)
                        {
                            if(student.Id==removeId)
                            {
                                studentToRemove = student;
                                break;
                            }
                        }
                        if(studentToRemove!=null)
                        {
                            students.Remove(studentToRemove);
                            Console.WriteLine("Student Removed.");
                        }
                        else
                        {
                            Console.WriteLine("Student Not Found.");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Total Students:"+students.Count);
                        break;
                    case 5:
                        Console.WriteLine("Enter Id:");
                        int id=Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Name:");
                        string name=Console.ReadLine();
                        Console.WriteLine("Enter Marks:");
                        int marks=Convert.ToInt32(Console.ReadLine());
                        students.Add(new Student(id, name, marks));
                        Console.WriteLine("Student Added Successfully");
                        break;
                    case 6:
                        Console.WriteLine("Program Ended.");
                        return;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Please Enter a valid number.");
            }
        }
    }
}