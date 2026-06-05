using System;

class Box<T>
{
    public T Value;

    public void Show()
    {
        Console.WriteLine(Value);
    }
}

class Program
{
    static void Main()
    {
        Box<int> numberBox = new Box<int>();
        numberBox.Value = 100;
        numberBox.Show();

        Box<string> textBox = new Box<string>();
        textBox.Value = "Hello";
        textBox.Show();
    }
}
