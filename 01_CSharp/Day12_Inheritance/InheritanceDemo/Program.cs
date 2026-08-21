using System;
class Program
{
    static void Main()
    {
        /*Dog dog = new Dog();
        dog.Eat();
        dog.Bark();
        Puppy puppy = new Puppy();
        puppy.Eat();
        puppy.Bark();
        puppy.Cry();
        Cat cat=new Cat();
        cat.Meow();*/
        Manager manager = new Manager("Mrunali");
        Console.WriteLine(manager.Name);
        Dog dog=new Dog();
        dog.Sound();
    }
}