using System;
class Animal
{
    public void Eat()
    {
        Console.WriteLine("Animal is Eating");
    }
    public virtual void Sound()
    {
        Console.WriteLine("Animal makes sound");
    }
}