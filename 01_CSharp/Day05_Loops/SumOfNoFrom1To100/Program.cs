using SumOfNoFrom1To100;
using System;
class Program
{
    static void Main(string[] args)
    {
        int sum = 0;
        for(int i = 1; i <= 100; i++)
        {
            sum += i;
        }
        Console.WriteLine("Sum of numbers from 1 to 100 is: " + sum);
        reversetable reversetable = new reversetable();
        reversetable.multiplicationtable();
        Pattern pattern = new Pattern();
        pattern.PrintPattern();
    }
}

