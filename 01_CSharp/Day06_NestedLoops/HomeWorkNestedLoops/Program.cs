using System;
class Program
{
    static void Main()
    {
        /*1) Write a program in C# Sharp to display the following pattern using the loop:
         11111
         22222
         33333
         44444
         55555
         */
        for (int i = 1; i <= 5; i++)
        {
            for (int j = 1; j <= 5; j++)
            {
                Console.Write(i);
            }
            Console.WriteLine();
        }
        /*2) Write a program in C# Sharp to display the following pattern using the loop:
         12345
         1234
         123
         12
         1
         */
        for (int i = 5; i >= 1; i--)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j);
            }
            Console.WriteLine();
        }
        /* 3) Write a program in C# Sharp to display the following pattern using the loop:
         1
         12
         123
         1234
         12345
         */
        for (int i = 1; i <= 5; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j);
            }
            Console.WriteLine();
        }
        /*4) Write a program in C# Sharp to display the following pattern using the loop:
           5 4 3 2 1
           5 4 3 2
           5 4 3    
           5 4
           5
         */
        for (int i = 5; i >= 1; i--)
        {
            for (int j = 5; j >= i; j--)
            {
                Console.Write(j);
            }
            Console.WriteLine();
            //Console.Write(i);
        }
        /* 5) Write a program in C# Sharp to display the following pattern using the loop:
           54321
           5432
           543
           54
           5
           */
        for (int i = 5; i >= 1; i--)
        {
            for (int j = 5; j >= i; j--)
            {
                Console.Write(j);
            }
            Console.WriteLine();
        }
        /*6) Write a program in C# Sharp to display the following pattern using the loop:
        A
        AB
        ABC
        ABCD
        ABCDE*/
        for (int i = 1; i <= 5; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write((char)(j + 64));
            }
            Console.WriteLine();
        }
        /* 7) Write a program in C# Sharp to display the following pattern using the loop:
         */
        for(int i=1;i <= 5; i++)
        {
            for(int j=1;j <= 5; j++)
            {
                if(j==2 && i==2 || j==3 && i==2 || j==4 && i==2 || i==3 &&j==2 || i==3 && j==3 || i==3 && j==4 || i==4 && j==2 || i==4 && j==3 || i==4 && j==4)
                {
                    Console.Write(" ");
                }
                else
                    Console.Write("*");
            }

            Console.WriteLine();
        }
    }
}