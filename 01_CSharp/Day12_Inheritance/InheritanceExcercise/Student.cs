using System;
class Student:Person
{
    public string Course;
    public void DisplayStudent()
    {
        Console.WriteLine("Course:" +Course);
    }
}