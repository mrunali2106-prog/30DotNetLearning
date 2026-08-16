class Program
{
    static void Main()
    {
        Employee employee;
        employee = new Manager();
        employee.CalculateSalary();
        employee=new Developer();
        employee.CalculateSalary();
    }
}