using System;

/*
    PARENT CLASS
*/

class Animal
{
    public void Sound()
    {
        Console.WriteLine("Animal Makes Sound");
    }
}

/*
    CHILD CLASS
*/

class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("Dog Barks");
    }
}

class Program
{
    static void Main()
    {
        Dog d = new Dog();

        d.Sound();
        d.Bark();
    }
}
