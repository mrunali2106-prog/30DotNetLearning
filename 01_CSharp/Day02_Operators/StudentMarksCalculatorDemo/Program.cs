    using System;
    class StudentMarksCalculator
    {
        static void Main()
        {
            Console.WriteLine("Enter Student Name:");
            string studentName = Console.ReadLine();
            Console.WriteLine("Enter Maths Marks:");
            int maths=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Science Marks:");
            int science=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter English Marks:");
            int english=Convert.ToInt32(Console.ReadLine());
            int total = maths + science + english;
            double avg = total / 3.0;
            double percentage = (total * 100) / 300;
            Console.WriteLine("Name:" + studentName);
            Console.WriteLine("Total:" + total);
            Console.WriteLine("Average:" + avg);
            Console.WriteLine("Percentage:" + percentage);
        }
    }