using System;
class Car
{
    public string Brand;
    public string Model;
    public void Start()
    {
        Console.WriteLine("Car Started Successfully.");
    }
}
class Program
{
    static void Main()
    {
        Car car=new Car();
        car.Brand = "Toyota";
        car.Model = "Fortuner";
        Console.WriteLine(car.Brand);
        Console.WriteLine(car.Model);
        car.Start();
    }
}
