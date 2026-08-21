class Program
{
    static void Main()
    {
        List<string> names = new List<string>();
        names.Add("Rahul");
        names.Add("Ajay");
        names.Add("Amit");
        names.Add("Raj");
        Console.WriteLine("Enter name to search:");
        string searchname = Console.ReadLine();
        if (names.Contains(searchname))
        {
            Console.WriteLine("Employee found");
        }
        else
        {
            Console.WriteLine("Employee not found");
        }
    }
}