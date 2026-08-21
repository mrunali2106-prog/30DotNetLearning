class Calculator
{
    public int Add(int n1, int n2)
    {
        return n1 + n2;
    }
    public int Add(int n1, int n2, int n3)
    {
        return n1 + n2 + n3;
    }
    public double Add(double n1, double n2)
    {
        return n1 + n2;
    }
}
class Program
{
    static void Main()
    {
        Calculator calculator = new Calculator();
        int r1=calculator.Add(10,10);
        int r2=calculator.Add(20, 30, 10);
        double r3=calculator.Add(20.5, 30.15);
        Console.WriteLine(r1); Console.WriteLine(r2); Console.WriteLine(r3);
    }
}