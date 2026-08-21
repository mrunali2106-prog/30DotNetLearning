class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Product(int id, string name)
    {
        Id = id;
        Name = name;
    }

}
class Program
{
    static void Main()
    {
        Dictionary<int,string> productNames=new Dictionary<int,string>();
        productNames.Add(101, "Laptop");
        productNames.Add(102, "Mouse");
        productNames.Add(103, "Keyboard");
        productNames.Add(104, "Monitor");
        Console.WriteLine("Enter Product Id:");
        int id=Convert.ToInt32(Console.ReadLine());
        if (productNames.ContainsKey(id))
        {
            Console.WriteLine("Product Name:" + productNames[id]);
        }
        else
        {
            Console.WriteLine("Product not found");
        }

    }
}