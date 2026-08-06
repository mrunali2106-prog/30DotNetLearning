using System;
class rogram
{
    static void Main()
    {
        /*1) Print "Hello" 5 times using a for loop.
         for (int i=1;i<=5;i++)
        {
            Console.WriteLine("Hello");
        }*/
        /*2) Print the numbers from 1 to 10 using a for loop.
        for(int i=1;i<=10;i++)
        {
            Console.WriteLine(i);
        }*/
        /*3) Print the even numbers from 2 to 20 using a for loop.
         * for (int i=2;i<=20;i+=2)
        {
            Console.WriteLine(i);
        }*/
        /*4) Print the multiplication table of 5 using a for loop.
        Console.WriteLine("Enter number");
        int num = Convert.ToInt32(Console.ReadLine());
        for (int i=1;i<=10;i++)
        {
            Console.WriteLine(num + " x " + i + " = " + (num * i));
        }*/
        /* 5) While loop to print numbers from 1 to 10.
                int i = 1;
                while (i <= 10)
                {
                    Console.WriteLine(i);
                    i++;
                }*/
        /*6) Do-while loop to print numbers from 1 to 10.
                int i = 1;
                do
                {
                    Console.WriteLine(i);
                    i++;
                } while (i <= 10);*/
        /* 7) Print factorial of a number using a for loop.
        Console.WriteLine("Enter a number:");
        int no = Convert.ToInt32(Console.ReadLine());
        int fact = 1;
        for (int i = 1; i <= no; i++)
        {
            fact = fact * i;
        }
        Console.WriteLine("Factorial of " + no + " is: " + fact);*/
        /* 8) For each loop to print elements of an array.*/
        string[] fruits = { "Apple", "Banana", "Cherry", "Date" };
        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }
    }
}