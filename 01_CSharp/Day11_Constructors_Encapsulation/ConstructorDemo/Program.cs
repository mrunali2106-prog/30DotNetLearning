using System;
class Program
{
    static void Main()
    {
        /*Student s=new Student("Mrunali");
        Student stud = new Student("Mrunali");
        stud.Display();

        BankAccount account = new BankAccount();
        account.Balance = 5000;
        Console.WriteLine(account.Balance);
        account.Balance = -1000;
        Employee e1 = new Employee();
        Employee e2 = new Employee("Mrunali");
        Employee e3 = new Employee("jiyanshi", 25);
        Product product= new Product();
        Console.WriteLine("Enter Product Name:");
        product.ProductName = Console.ReadLine();
        Console.WriteLine("Enter Price:");
        product.Price=Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Product Details");
        Console.WriteLine("Product Name:"+product.ProductName);
        Console.WriteLine("Price:" + product.Price);*/
        Car car = new Car("Toyota", "Fortuner", 2025);
        car.DisplayDetails();
    }
}