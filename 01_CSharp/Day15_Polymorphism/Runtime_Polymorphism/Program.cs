class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Animal sounds");
    }
}
class Dog:Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Dog Barks");
    }
}
class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Cat meows");
    }
}
class Program
{
    static void Main()
    {
        Animal animal;
        animal= new Dog();
        animal.MakeSound();
        animal= new Cat();
        animal.MakeSound();
    }
}