using System;
class Product
{
    public int ProductId;
    public string ProductName;
    public double Price;
    public void DisplayProduct()
    {
        Console.WriteLine(ProductId);
        Console.WriteLine(ProductName);
        Console.WriteLine(Price);
    }
}
class Program
{
    static void Main()
    {
        Product product = new Product();
        product.ProductId = 1;
        product.ProductName = "Laptop";
        product.Price = 55000;
        product.DisplayProduct();
    }
}