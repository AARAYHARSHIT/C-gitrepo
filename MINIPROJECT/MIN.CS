using System;
using System.Collections.Generic;

/*
    CLASS:
    A class is a blueprint/template for creating objects.

    Here, Student class is used to store:
    - Student ID
    - Student Name
    - Student Marks
*/
class Student
{
    // VARIABLES / DATA MEMBERS
    public int Id;
    public string Name;
    public int Marks;
}

class Program
{
    /*
        LIST COLLECTION:
        List<Student> stores multiple student objects dynamically.

        Example:
        students[0]
        students[1]
        etc.
    */
    static List<Student> students = new List<Student>();

    /*
        MAIN METHOD:
        Execution of program starts from Main().
    */
    static void Main()
    {
        /*
            INFINITE LOOP:
            while(true) keeps menu running continuously
            until user chooses Exit option.
        */
        while (true)
        {
            Console.WriteLine("\n=================================");
            Console.WriteLine("   STUDENT MANAGEMENT SYSTEM");
            Console.WriteLine("=================================");

            // MENU OPTIONS
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. View All Students");
            Console.WriteLine("3. Search Student");
            Console.WriteLine("4. Exit");

            // TAKING INPUT FROM USER
            Console.Write("\nEnter Your Choice: ");

            /*
                Convert.ToInt32():
                Converts string input into integer.
            */
            int choice = Convert.ToInt32(Console.ReadLine());

            /*
                SWITCH CASE:
                Used when multiple choices/options exist.
            */
            switch (choice)
            {
                case 1:
                    AddStudent();
                    break;

                case 2:
                    ViewStudents();
                    break;

                case 3:
                    SearchStudent();
                    break;

                case 4:
                    Console.WriteLine("\nProgram Closed Successfully!");
                    return;

                default:
                    Console.WriteLine("\nInvalid Choice!");
                    break;
            }
        }
    }

    /*
        METHOD:
        Method is a block of code that performs a specific task.

        This method adds student details.
    */
    static void AddStudent()
    {
        /*
            OBJECT CREATION:

            Student s = new Student();

            - Student → class name
            - s → object name
            - new → creates object in memory
        */
        Student s = new Student();

        Console.Write("\nEnter Student ID: ");
        s.Id = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Student Name: ");
        s.Name = Console.ReadLine();

        Console.Write("Enter Student Marks: ");
        s.Marks = Convert.ToInt32(Console.ReadLine());

        /*
            ADDING OBJECT INTO LIST
        */
        students.Add(s);

        Console.WriteLine("\nStudent Added Successfully!");
    }

    /*
        METHOD TO DISPLAY ALL STUDENTS
    */
    static void ViewStudents()
    {
        /*
            IF CONDITION:
            Checks whether list is empty or not.
        */
        if (students.Count == 0)
        {
            Console.WriteLine("\nNo Students Found!");
            return;
        }

        Console.WriteLine("\n========== STUDENT LIST ==========");

        /*
            FOREACH LOOP:

            Used to access every object from list one-by-one.
        */
        foreach (Student s in students)
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Student ID    : " + s.Id);
            Console.WriteLine("Student Name  : " + s.Name);
            Console.WriteLine("Student Marks : " + s.Marks);
        }
    }

    /*
        METHOD TO SEARCH STUDENT BY ID
    */
    static void SearchStudent()
    {
        Console.Write("\nEnter Student ID To Search: ");

        int searchId = Convert.ToInt32(Console.ReadLine());

        /*
            BOOLEAN VARIABLE:
            Used to track whether student is found or not.
        */
        bool found = false;

        /*
            LOOPING THROUGH ALL STUDENTS
        */
        foreach (Student s in students)
        {
            /*
                IF CONDITION:
                Compares entered ID with existing student ID.
            */
            if (s.Id == searchId)
            {
                Console.WriteLine("\nStudent Found!");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("Student ID    : " + s.Id);
                Console.WriteLine("Student Name  : " + s.Name);
                Console.WriteLine("Student Marks : " + s.Marks);

                found = true;

                // BREAK:
                // Stops loop immediately after finding student.
                break;
            }
        }

        /*
            !found means:
            If found == false
        */
        if (!found)
        {
            Console.WriteLine("\nStudent Not Found!");
        }
    }
}