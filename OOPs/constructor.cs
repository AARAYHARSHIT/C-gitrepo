using System;

class Student
{
    public string Name;

    /*
        CONSTRUCTOR:
        Automatically called when object is created.
    */

    public Student(string studentName)
    {
        Name = studentName;
    }
}

class Program
{
    static void Main()
    {
        Student s1 = new Student("Harshit");

        Console.WriteLine(s1.Name);
    }
}
