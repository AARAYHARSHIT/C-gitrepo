using System;
using System.Collections.Generic;
using System.IO;

/*
    =====================================================
        STUDENT MANAGEMENT SYSTEM (FULL BEGINNER PROJECT)
    =====================================================

    FEATURES:
    1. Login System
    2. Add Student
    3. View Students
    4. Search Student
    5. Update Student
    6. Delete Student
    7. Grade Calculation
    8. File Saving
    9. File Loading

    CONCEPTS USED:
    - Class & Objects
    - Methods
    - List Collection
    - Loops
    - Switch Case
    - File Handling
    - CRUD Operations
    - Login Authentication
    - Grade Logic
*/

class Student
{
    // DATA MEMBERS / VARIABLES

    public int Id;
    public string Name;
    public int Marks;
    public string Grade;
}

class Program
{
    /*
        LIST COLLECTION:
        Stores multiple student objects.
    */
    static List<Student> students = new List<Student>();

    /*
        FILE PATH:
        Student data will be saved here.
    */
    static string filePath = "students.txt";

    /*
        LOGIN CREDENTIALS
    */
    static string username = "admin";
    static string password = "1234";

    static void Main()
    {
        /*
            LOGIN SYSTEM
        */
        Login();

        /*
            LOAD DATA FROM FILE
        */
        LoadFromFile();

        /*
            MAIN MENU LOOP
        */
        while (true)
        {
            Console.WriteLine("\n=================================");
            Console.WriteLine("   STUDENT MANAGEMENT SYSTEM");
            Console.WriteLine("=================================");

            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. View Students");
            Console.WriteLine("3. Search Student");
            Console.WriteLine("4. Update Student");
            Console.WriteLine("5. Delete Student");
            Console.WriteLine("6. Save Data");
            Console.WriteLine("7. Exit");

            Console.Write("\nEnter Choice: ");

            int choice = Convert.ToInt32(Console.ReadLine());

            /*
                SWITCH CASE:
                Executes selected option.
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
                    UpdateStudent();
                    break;

                case 5:
                    DeleteStudent();
                    break;

                case 6:
                    SaveToFile();
                    break;

                case 7:
                    Console.WriteLine("\nSaving Data Before Exit...");
                    SaveToFile();

                    Console.WriteLine("Program Closed Successfully!");
                    return;

                default:
                    Console.WriteLine("\nInvalid Choice!");
                    break;
            }
        }
    }

    /*
        LOGIN METHOD
    */
    static void Login()
    {
        Console.WriteLine("=================================");
        Console.WriteLine("          LOGIN SYSTEM");
        Console.WriteLine("=================================");

        /*
            LOOP UNTIL CORRECT LOGIN
        */
        while (true)
        {
            Console.Write("\nEnter Username: ");
            string user = Console.ReadLine();

            Console.Write("Enter Password: ");
            string pass = Console.ReadLine();

            /*
                CHECK USERNAME & PASSWORD
            */
            if (user == username && pass == password)
            {
                Console.WriteLine("\nLogin Successful!");
                break;
            }
            else
            {
                Console.WriteLine("\nInvalid Username or Password!");
            }
        }
    }

    /*
        METHOD TO CALCULATE GRADE
    */
    static string CalculateGrade(int marks)
    {
        /*
            IF ELSE LADDER:
            Used for multiple conditions.
        */

        if (marks >= 90)
        {
            return "A+";
        }
        else if (marks >= 75)
        {
            return "A";
        }
        else if (marks >= 60)
        {
            return "B";
        }
        else if (marks >= 40)
        {
            return "C";
        }
        else
        {
            return "Fail";
        }
    }

    /*
        METHOD TO ADD STUDENT
    */
    static void AddStudent()
    {
        /*
            OBJECT CREATION
        */
        Student s = new Student();

        Console.Write("\nEnter Student ID: ");
        s.Id = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Student Name: ");
        s.Name = Console.ReadLine();

        Console.Write("Enter Student Marks: ");
        s.Marks = Convert.ToInt32(Console.ReadLine());

        /*
            GRADE CALCULATION
        */
        s.Grade = CalculateGrade(s.Marks);

        students.Add(s);

        Console.WriteLine("\nStudent Added Successfully!");
    }

    /*
        METHOD TO VIEW STUDENTS
    */
    static void ViewStudents()
    {
        if (students.Count == 0)
        {
            Console.WriteLine("\nNo Students Found!");
            return;
        }

        Console.WriteLine("\n========== STUDENT LIST ==========");

        /*
            FOREACH LOOP
        */
        foreach (Student s in students)
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("ID     : " + s.Id);
            Console.WriteLine("Name   : " + s.Name);
            Console.WriteLine("Marks  : " + s.Marks);
            Console.WriteLine("Grade  : " + s.Grade);
        }
    }

    /*
        METHOD TO SEARCH STUDENT
    */
    static void SearchStudent()
    {
        Console.Write("\nEnter Student ID To Search: ");

        int searchId = Convert.ToInt32(Console.ReadLine());

        bool found = false;

        foreach (Student s in students)
        {
            if (s.Id == searchId)
            {
                Console.WriteLine("\nStudent Found!");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("ID     : " + s.Id);
                Console.WriteLine("Name   : " + s.Name);
                Console.WriteLine("Marks  : " + s.Marks);
                Console.WriteLine("Grade  : " + s.Grade);

                found = true;

                break;
            }
        }

        if (!found)
        {
            Console.WriteLine("\nStudent Not Found!");
        }
    }

    /*
        METHOD TO UPDATE STUDENT
    */
    static void UpdateStudent()
    {
        Console.Write("\nEnter Student ID To Update: ");

        int updateId = Convert.ToInt32(Console.ReadLine());

        bool found = false;

        foreach (Student s in students)
        {
            if (s.Id == updateId)
            {
                Console.WriteLine("\nStudent Found!");

                Console.Write("Enter New Name: ");
                s.Name = Console.ReadLine();

                Console.Write("Enter New Marks: ");
                s.Marks = Convert.ToInt32(Console.ReadLine());

                /*
                    UPDATE GRADE AUTOMATICALLY
                */
                s.Grade = CalculateGrade(s.Marks);

                Console.WriteLine("\nStudent Updated Successfully!");

                found = true;

                break;
            }
        }

        if (!found)
        {
            Console.WriteLine("\nStudent Not Found!");
        }
    }

    /*
        METHOD TO DELETE STUDENT
    */
    static void DeleteStudent()
    {
        Console.Write("\nEnter Student ID To Delete: ");

        int deleteId = Convert.ToInt32(Console.ReadLine());

        bool found = false;

        /*
            FOR LOOP:
            Safe for deletion operation.
        */
        for (int i = 0; i < students.Count; i++)
        {
            if (students[i].Id == deleteId)
            {
                students.RemoveAt(i);

                Console.WriteLine("\nStudent Deleted Successfully!");

                found = true;

                break;
            }
        }

        if (!found)
        {
            Console.WriteLine("\nStudent Not Found!");
        }
    }

    /*
        METHOD TO SAVE DATA INTO FILE
    */
    static void SaveToFile()
    {
        /*
            StreamWriter:
            Writes data into file.
        */
        StreamWriter writer = new StreamWriter(filePath);

        foreach (Student s in students)
        {
            /*
                FILE FORMAT:
                ID,Name,Marks,Grade
            */
            writer.WriteLine(
                s.Id + "," +
                s.Name + "," +
                s.Marks + "," +
                s.Grade
            );
        }

        writer.Close();

        Console.WriteLine("\nData Saved Successfully!");
    }

    /*
        METHOD TO LOAD DATA FROM FILE
    */
    static void LoadFromFile()
    {
        /*
            CHECK FILE EXISTENCE
        */
        if (File.Exists(filePath))
        {
            /*
                READ ALL FILE LINES
            */
            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                /*
                    SPLIT DATA USING COMMA
                */
                string[] data = line.Split(',');

                /*
                    CREATE OBJECT
                */
                Student s = new Student();

                s.Id = Convert.ToInt32(data[0]);
                s.Name = data[1];
                s.Marks = Convert.ToInt32(data[2]);
                s.Grade = data[3];

                students.Add(s);
            }

            Console.WriteLine("\nPrevious Data Loaded Successfully!");
        }
    }
}