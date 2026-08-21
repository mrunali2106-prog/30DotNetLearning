using System;
class Car :Vehicle
{
    public int Year;

    public void DisplayCar()
    {
        DisplayVehicle();
        Console.WriteLine("Year:" +Year);
    }
}