using System;
class Circle:Shape
{
    public void CalculateArea()
    {
        Console.WriteLine("Enter radius :");
        double raduis=Convert.ToDouble(Console.ReadLine());
        double area=Math.PI*raduis*raduis;
        Console.WriteLine("Area of Circle:" + area);
    }
}