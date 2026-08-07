using System;
class Mobile
{
    public string Brand;
    public string Model;
    public void Call()
    {
        Console.WriteLine("Calling...");
    }
    public void Message()
    {
        Console.WriteLine("Sending Message...");
    }
}
class Program
{
    static void Main()
    {
        Mobile m = new Mobile();
        m.Brand = "Samsung";
        m.Model = "Galaxy S24";

        Console.WriteLine("Brand:" + m.Brand);
        Console.WriteLine("Model:" +m.Model);
        m.Call();
        m.Message();
    }
}