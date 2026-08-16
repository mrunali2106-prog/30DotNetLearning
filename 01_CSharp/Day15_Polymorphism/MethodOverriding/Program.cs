class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Animal make sound");
    }
}
class Dog :Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Dog barks");
    }
}
class Cat:Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("cat mewos");
    }
}
class Program
{
    static void Main()
    {
        Animal animal = new Dog();
        Animal animal1 = new Cat();
        animal.MakeSound();
        animal1.MakeSound();
    }
}