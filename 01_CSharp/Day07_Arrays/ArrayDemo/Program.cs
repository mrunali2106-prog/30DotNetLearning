using System;
class Program
{
    static void Main()
    {
        /* 1) Declare and Print Array*/
        int[] numbers = { 10, 20, 30, 40, 50 };
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }
        /*2) Access Elements */
        string[] names = { "Amit", "Rahul", "Priya", "Neha", "Rohit" };
        foreach (var name in names)
        {
            Console.WriteLine(name);
        }
        /* 3) Modify Elements */
        int[] usernumbers = new int[5];
        for (int i = 0; i < usernumbers.Length; i++)
        {
            Console.WriteLine("Enter number:");
            usernumbers[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine();
        foreach (var number in usernumbers)
        {
            Console.WriteLine(number);
        }
        /*4) Sum of Array Elements */
        int[] sumArray = { 1, 2, 3, 4, 5 };
        int sum = 0;
        foreach (var number in sumArray)
        {
            sum = sum + number;
        }
        Console.WriteLine("Sum of Array Elements:" + sum);
        /*5) Average of Array Elements */
        int[] marks = { 50, 60, 70, 80, 90 };
        int total = 0;
        foreach (var item in marks)
        {
            total += item;
        }
        Console.WriteLine("Total of Marks:" + total);
        int average = total / marks.Length;
        Console.WriteLine(average);
        /*6) Find Maximum and Minimum Elements */
    int[] findmax = { 50, 45, 20, 30, 10, 5 };
        int max=findmax[0];
        int min = findmax[0];
        foreach(var item in findmax)
        {
            if(item > max)
            {
                max = item;
            }
            if(item < min)
            {
                min = item;
            }
        }
        Console.WriteLine("MAXIMUM ELEMENT:" + max);
        Console.WriteLine("MINIMUM ELEMENT:" + min);

        /*7) Search for an array Element */
        int[] searchElement = { 10,50,20,40,30 };
        Console.WriteLine("Enter the element to search:");
        int search=Convert.ToInt32 (Console.ReadLine());
        bool found = false;
        foreach(var item in searchElement)
        {
            if(item == search)
            {
                found = true;
                break;
            }
        }
        if(found)
        {
            Console.WriteLine("Element found in the array.");
        }
        else
        {
            Console.WriteLine("Element not found in the array.");
        }
    }
}