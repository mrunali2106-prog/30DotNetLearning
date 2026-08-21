using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Queue<string> customers = new Queue<string>();
        customers.Enqueue("Mrunali");
        customers.Enqueue("Rahul");
        customers.Enqueue("Amit");
        customers.Enqueue("Pooja");
        customers.Enqueue("Karan");
        Console.WriteLine("Customers in Queue:");
        foreach (string customer in customers)
        {
            Console.WriteLine(customer);
        }
        Console.WriteLine();
        Console.WriteLine("Next Customer");
        Console.WriteLine(customers.Peek());
        Console.WriteLine();
        Console.WriteLine("Served Customer:");
        Console.WriteLine(customers.Dequeue());
        Console.WriteLine();
        Console.WriteLine("Served Customer:");
        Console.WriteLine(customers.Dequeue());
        Console.WriteLine("Remaining Customers:");
        foreach(string customer in customers)
        {
            Console.WriteLine(customer);
        }
        Console.WriteLine("Count Display:"+ customers.Count);
    }
}