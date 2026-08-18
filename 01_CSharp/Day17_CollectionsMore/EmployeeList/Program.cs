using System;
class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Employee(int id, string name)
    {
        Id = id;
        Name = name;
    }
}
class Program
{
    static void Main()
    {
        List<Employee> employees = new List<Employee>();
        employees.Add(new Employee(101, "Amit"));
        employees.Add(new Employee(102, "Jay"));
        employees.Add(new Employee(103, "Ajay"));
        employees.Add(new Employee(104, "Jayesh"));
        employees.Add(new Employee(105, "Jignesh"));
        foreach(Employee employee in employees)
        {
            Console.WriteLine("ID:"+employee.Id+" Name:"+employee.Name);
        }
    }
}