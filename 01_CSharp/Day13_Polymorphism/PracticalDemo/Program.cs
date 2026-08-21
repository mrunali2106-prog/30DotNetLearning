using System;
class Program
{
    static void Main()
    {
        /*1) calculator */
        Calculator calc = new Calculator();
        calc.Add(10, 20);
        calc.Add(10, 20, 30);
        calc.Add(1.25,20.2005);

        /* 2) Animal */
        Animal animal;
        animal = new Dog();
        animal.Sound();
        animal = new Cat();
        animal.Sound();

        /*3) Payment */
        Payment payment;
        payment=new UPI();
        payment.Pay();

        payment = new CreditCard();
        payment.Pay();
        payment = new Cash();
        payment.Pay();

        /*4) Employee */
        Employee employee;
        employee=new Manager();
        employee.Work();
        employee = new Developer();
        employee.Work();

        /*5) Shape*/
        Shape shape;
        shape =new Circle();
        shape.CalculateArea();
        shape = new Rectangle();
        shape.CalculateArea();

    }
}