using System;
class Laptop
{
    public string Brand;
    public int RAM;
    public int Price;
    public void DisplayData()
    {
        Console.WriteLine("Brand:" + Brand);    
        Console.WriteLine("Price:"+Price);
        Console.WriteLine("RAM" + RAM);
    }
}
class Program
{
    static void Main()
    {
        Laptop l = new Laptop();
        l.Brand = "Lenovo";
        l.Price = 50000;
        l.RAM=2;
        l.DisplayData();
    }
}