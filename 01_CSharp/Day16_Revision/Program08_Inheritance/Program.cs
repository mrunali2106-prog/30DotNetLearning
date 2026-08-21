class Employee
{
    public int Id;
    public string Name;
    public double Salary;
    public Employee()
    {
        Console.WriteLine("Employee Management");
    }
}
class Developer:Employee
{
    public Developer()
    {
        Console.WriteLine("Programming Language");
    }
}
class Program
{
    static void Main()
    {
        Developer developer=new Developer();
    }
}