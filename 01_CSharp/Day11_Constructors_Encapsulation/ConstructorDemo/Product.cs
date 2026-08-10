using System;
class Product
{
    public string ProductName { get; set; }
    private double price;
    public double Price
    {
        get
        {
            return price;
        }
        set
        {
            if (value < 0)
            {
                Console.WriteLine("Invalid Price");
            }
            else
            {
                price = value;
            }
        }
    }
}