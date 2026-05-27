using System;

class Animal
{
    /*
        VIRTUAL METHOD
    */

    public virtual void Sound()
    {
        Console.WriteLine("Animal Sound");
    }
}

class Dog : Animal
{
    /*
        OVERRIDE METHOD
    */

    public override void Sound()
    {
        Console.WriteLine("Dog Barks");
    }
}

class Program
{
    static void Main()
    {
        Animal a = new Dog();

        a.Sound();
    }
}