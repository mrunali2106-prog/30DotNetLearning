using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter Student Name:");
        string name=Console.ReadLine();
        Console.WriteLine("Enter Maths Marks:");
        int maths=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Science Marks:");
        int sci=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter English Marks:");
        int eng=Convert.ToInt32(Console.ReadLine());
        int total = maths + sci + eng;
        double average = total / 3;
        double percentage=average / 100;
        string result;
        if(percentage >35)
        {
            result = "pass";
        }
        else
        {
            result = "fail";
        }

        Console.WriteLine("Final Result");
        Console.WriteLine("Stundet Name:" + name);
        Console.WriteLine("Maths Marks:" + maths);
        Console.WriteLine("Science Marks:" + sci);
        Console.WriteLine("English Marks:" + eng);
        Console.WriteLine("Total :" + total);
        Console.WriteLine("Average:" + average);
        Console.WriteLine("Percentage:" + percentage);
        Console.WriteLine("Result:" + result);
    }
}