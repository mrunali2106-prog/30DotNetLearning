class Employee
{
   // public int Id { get; set; }
    //public string Name { get; set; }
}
class Program
{
    static void Main()
    {
        Dictionary<int,string> employees=new Dictionary<int, string>();
        employees.Add(101, "Amit");
        employees.Add(102, "Neha");
        employees.Add(103, "Raj");
        foreach(var employee in employees)
        {
            Console.WriteLine(employee.Key + employee.Value);
        }
        Console.WriteLine();
        Console.WriteLine("Search Employee:");
        int id = Convert.ToInt32(Console.ReadLine());
        if(employees.TryGetValue(id,out string name))
        {
            Console.WriteLine(name);
        }
        Console.WriteLine();
        Console.WriteLine("Update employee");
        employees[102] = "priya";
        Console.WriteLine("102 - " + employees[102]);
        Console.WriteLine();
        Console.WriteLine("Removing employee");
        employees.Remove(103);
        foreach(var employee in employees)
        {
            Console.WriteLine(employee.Key+employee.Value);
        }
    }
}