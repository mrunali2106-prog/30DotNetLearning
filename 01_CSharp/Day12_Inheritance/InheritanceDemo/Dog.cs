using System;
class Dog:Animal
{
    public void Bark()
    {
        Console.WriteLine("Dog is barking");
    }
    public override void Sound()
    {
        Console.WriteLine("Dog barks");
    }
}