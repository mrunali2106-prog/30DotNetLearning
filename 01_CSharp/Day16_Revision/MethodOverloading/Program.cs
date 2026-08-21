using System;
class Calculator
{
    public void Add(int a, int b)
    {
        Console.WriteLine(a + b);
    }
    public void Add(int a, int b, int c)
    {
        Console.WriteLine(a + b + c);
    }
    public void Add(double a, double b, double c)
    {
        Console.WriteLine(a + b + c);
    }
}
class Program
{
    static void Main()
    { 
      Calculator c = new Calculator();
        c.Add(10, 50);
        c.Add(10, 50, 66);
        c.Add(20.5, 25, 2.2);
    }
}