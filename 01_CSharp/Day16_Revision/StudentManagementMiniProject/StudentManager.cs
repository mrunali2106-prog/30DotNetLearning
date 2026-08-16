class StudentManager:IStudentOperation
{
    private Student[] students = new Student[5];
    private int StudentCount=0;
    public void AddStudent(Student student)
    {
        if (StudentCount >= students.Length)
        {
            Console.WriteLine("Student limit reached.");
            return;
        }
        students[StudentCount] = student;
        StudentCount++;
        Console.WriteLine("Student added successfully.");
    }
    public void DisplayStudents()
    {
        if (StudentCount == 0)
        {
            Console.WriteLine("No students found.");
            return;
        }

        for (int i = 0; i < StudentCount; i++)
        {
            students[i].Display();
        }
    }
    public double CalculateAverage()
    {
        if (StudentCount == 0)
        {
            return 0;
        }

        int total = 0;

        for (int i = 0; i < StudentCount; i++)
        {
            total += students[i].Marks;
        }

        return (double)total / StudentCount;
    }
    public int FindHighestMarks()
    {
        int highest = students[0].Marks;
        for(int i = 0;i<StudentCount;i++)
        {
            if(students[i].Marks > highest)
            {
                highest = students[i].Marks;
            }
        }
        return highest;
    }

}