using System;
class Program
{
    static void Main()
    {
        Calculator calc = new Calculator();
        Console.WriteLine(calc.Add(10, 10));
        Console.WriteLine(calc.Add(10, 20, 30));
        Console.WriteLine(calc.Add(10.5,20.5));

        Animal animal;
        animal = new Dog();
        animal.Sound();
        animal = new Cat();
        animal.Sound();

        Payment payment;
        payment = new UPI();
        payment.Pay();
        payment =new CreditCard();
        payment.Pay();

        Employee employee;
        employee = new Manager();
        employee.Work();

        employee = new Developer();
        employee.Work();
    }
}