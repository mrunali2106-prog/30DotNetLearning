using System;
class Car
{
    public string Company;
    public string Model;
    public int Year;
    public Car(string company, string model, int year )
    {
        Company = company;
        Model = model;
        Year = year;
    }
    public void DisplayDetails()
    {
        Console.WriteLine("Car Details");
        Console.WriteLine("------------");
        Console.WriteLine("Company:" + Company);
        Console.WriteLine("Model:" + Model);
        Console.WriteLine("Year:"+Year);
    }
}