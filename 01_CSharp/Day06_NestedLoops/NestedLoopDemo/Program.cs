using System;
class Program
{
    static void Main()
    {
        /*1) Write a C# program to print the following pattern using nested for loops.
            * * * * * *

            * * * * *

            * * * * *

            * * * * *

            * * * * *
         */
        for (int i = 1; i <= 5; i++)
        {
            for (int j = 1; j <= 5; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        /*2) Write a C# program to print the following pattern using nested for loops.
            *
            * *
            * * *
            * * * *
            * * * * *
        */
        for (int i = 1; i <= 5; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
        /*3) Write a C# program to print the following pattern using nested for loops.
            * * * * *
            * * * *
            * * *
            * *
            *
         */
        for (int i = 5; i >= 1; i--)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }

        /*4) Write a C# program to print the following pattern using nested for loops.
            1 2 3 4 5

            1 2 3 4 5

            1 2 3 4 5

            1 2 3 4 5

            1 2 3 4 5


         */
        for (int i = 1; i <= 5; i++)
        {
            for (int j = 1; j <= 5; j++)
            {
                Console.Write(j);
            }
            Console.WriteLine();
        }
        /*5) Write a C# program to print the following pattern using nested for loops.
            1

            1 2

            1 2 3

            1 2 3 4

            1 2 3 4 5
         */
        for (int i = 1; i <= 5; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j);
            }
            Console.WriteLine();
        }
        /*6) Write a C# program to print the following pattern using nested for loops.
            1
            2 2
            3 3 3
            4 4 4 4
            5 5 5 5 5
         */
        for (int i = 1; i <= 5; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(i);
            }
            Console.WriteLine();
        }
    }
}