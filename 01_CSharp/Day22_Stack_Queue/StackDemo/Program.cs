using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        Stack<string>names=new Stack<string>();
        names.Push("Mrunali");
        names.Push("Rahul");
        names.Push("Amit");
        names.Push("Pooja");
        names.Push("Karan");
        Console.WriteLine("Stack Items:");
        foreach(string name in names)
        {
            Console.WriteLine(name);
        }
        Console.WriteLine();
        Console.WriteLine("Top Item:");
        Console.WriteLine(names.Peek());
        Console.WriteLine();
        Console.WriteLine("Removed Item:");
        Console.WriteLine(names.Pop());
        Console.WriteLine();
        Console.WriteLine("Removed Item:");
        Console.WriteLine(names.Pop());
        Console.WriteLine();
        Console.WriteLine("Remaining Items:");
        foreach(string name in names)
        {
            Console.WriteLine(name);
        }
        Console.WriteLine(names.Count);
    }
}