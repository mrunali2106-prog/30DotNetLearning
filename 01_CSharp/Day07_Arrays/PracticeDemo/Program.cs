using System;
class Program
{
    static void Main()
    {
        /*1) Display all students name*/
        string[] studentname = { "rahul", "ajay", "ram" };
        foreach (var stud in studentname)
        {
            Console.WriteLine(stud);
        }

        /*2) Find total marks */

        int[] marks = { 60, 70, 40, 50, 10 };
        int total = 0;
        foreach (int mark in marks)
        {
            total += mark;
        }
        Console.WriteLine(total);
        /*3) Find maximum salary*/
        int[] salary = { 600, 7000, 4000, 50000, 10000 };
        int max = salary[0];

        foreach (int maxsalary in salary)
        {
            if (maxsalary > max)
            {
                max = maxsalary;
            }
        }
        Console.WriteLine("Max Salary is: " + max);
        /*4) Find minimum temperature */
        int[] temp = { 50, 40, 32, 24, 18, 20 };
        int min = temp[0];

        foreach (int mintemp in temp)
        {
            if (mintemp < min)
            {
                min = mintemp;
            }
        }
        Console.WriteLine("Lowest tempature :" + min);

        /*5) Search employee id */
        int[] employeeid = { 101, 104, 102, 103, 105 };

        Console.WriteLine("Search EmployeeId:");
        int empid = Convert.ToInt32(Console.ReadLine());
        bool find = false;
        foreach (int eid in employeeid)
        {
            if (empid == eid)
            {
                find = true;
                break;
            }

        }
        if (find)
        {
            Console.WriteLine("Employee Found");
        }
        else
        {
            Console.WriteLine("Employee not found");
        }
        /*6) Count number of even and odd numbers*/
        int[] no = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int countodd = 0;
        int counteven = 0;
        foreach (var item in no)
        {
            if (item % 2 == 0)
            {
                counteven += 1;
            }
            else
            {
                countodd += 1;
            }
        }
        Console.WriteLine("Even numbers: " + counteven + ", Odd numbers: " + countodd);

        /*7) Reverse an array*/
        int[] numbers = { 1, 2, 3, 4, 5 };

        for (int i = numbers.Length - 1; i >= 0; i--)
        {
            Console.WriteLine(numbers[i]);
        }
        /*8) Find sum and average of take number of elements from user*/

        Console.WriteLine("Enter the number of elements:");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] markstotal = new int[n];
        Console.WriteLine("Enter the elements:");
        for (int i = 0; i < n; i++)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            markstotal[i] = n;
        }
        int totalmarks = 0;
        for (int i = 0; i < n; i++)
        {
            totalmarks += markstotal[i];
        }
        Console.WriteLine("Total: " + totalmarks);
        Console.WriteLine("Average: " + (totalmarks / n));
        /*9) Reverse an array using user input*/

            Console.Write("Enter the number of elements: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[num];

            Console.WriteLine("Enter the elements:");

            for (int i = 0; i < num; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            int start = 0;
            int end = n - 1;

            while (start < end)
            {
                int tempno = arr[start];
                arr[start] = arr[end];
                arr[end] = tempno;

                start++;
                end--;
            }

            Console.WriteLine("Reversed Array:");

            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    
}