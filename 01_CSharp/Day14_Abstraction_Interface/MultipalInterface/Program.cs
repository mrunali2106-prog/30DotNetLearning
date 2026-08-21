interface IPrintable
{
    void Print();
}
interface ISavable
{
    void Save();
}
class Report:IPrintable,ISavable
{
    public void Print()
    {
        Console.WriteLine("Report Printed");
    }
    public void Save()
    {
        Console.WriteLine("Report Saved");
    }
}
class Program
{
    static void Main()
    {
        Report report =new Report();
        report.Print();
        report.Save();
    }
}