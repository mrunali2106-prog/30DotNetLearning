using System;
class Program
{
    static void Main()
    {
        IStudentOperation manager = new StudentManager();
        while (true)
        { 
            Console.WriteLine("=========================================");
            Console.WriteLine("         Student Management              ");
            Console.WriteLine("=========================================");
            Console.WriteLine("1.Add Student");
            Console.WriteLine("2.Display Student");
            Console.WriteLine("3.Calculate Average");
            Console.WriteLine("4.Find Highest Marks");
            Console.WriteLine("5.Exit");
            Console.WriteLine();
            try
            {
                Console.WriteLine("Enter your choice");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Student Id:");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Student Name:");
                        string name = Console.ReadLine();
                        Console.Write("Enter Marks:");
                        int marks = Convert.ToInt32(Console.ReadLine());
                        if (marks < 0 || marks > 100)
                        {
                            Console.WriteLine("Marks must be between 0 and 100");
                            break;
                        }
                        Student student = new Student(id, name, marks);
                        manager.AddStudent(student);
                        break;
                    case 2:
                        manager.DisplayStudents();
                        break;
                    case 3:
                        double average = manager.CalculateAverage();
                        Console.WriteLine("Average Marks" + average);
                        break;
                    case 4:
                        int highest = manager.FindHighestMarks();
                        Console.WriteLine("Highest Marks:" + highest);
                        break;
                    case 5:
                        Console.WriteLine("Thank you!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice.Please select 1-5.");
                    break;
                            }
            
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error:ex.Message");
        }
    
        } 
    }
}