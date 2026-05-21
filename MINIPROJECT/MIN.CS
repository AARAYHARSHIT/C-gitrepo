using System;
using System.Collections.Generic;
using System.IO; // Used for file handling

/*
    ============================================
        STUDENT MANAGEMENT SYSTEM (ADVANCED)
    ============================================

    FEATURES:
    1. Add Student
    2. View Students
    3. Search Student
    4. Update Student
    5. Delete Student
    6. File Saving
    7. File Loading

    CONCEPTS USED:
    - Class & Object
    - List Collection
    - Methods
    - Loops
    - Switch Case
    - File Handling
    - CRUD Operations
*/

class Student
{
    // DATA MEMBERS / VARIABLES
    public int Id;
    public string Name;
    public int Marks;
}

class Program
{
    /*
        LIST:
        Stores all student objects.
    */
    static List<Student> students = new List<Student>();

    /*
        FILE PATH:
        Data will be stored inside this file.
    */
    static string filePath = "students.txt";

    static void Main()
    {
        /*
            LOAD DATA FROM FILE
            when program starts.
        */
        LoadFromFile();

        /*
            INFINITE LOOP:
            Keeps program running continuously.
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
            Console.WriteLine("6. Save Data To File");
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

                    Console.WriteLine("Program Closed!");
                    return;

                default:
                    Console.WriteLine("\nInvalid Choice!");
                    break;
            }
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
            ADD OBJECT INTO LIST
        */
        students.Add(s);

        Console.WriteLine("\nStudent Added Successfully!");
    }

    /*
        METHOD TO VIEW STUDENTS
    */
    static void ViewStudents()
    {
        /*
            CHECK IF LIST IS EMPTY
        */
        if (students.Count == 0)
        {
            Console.WriteLine("\nNo Students Found!");
            return;
        }

        Console.WriteLine("\n========== STUDENT LIST ==========");

        /*
            FOREACH LOOP:
            Accesses every student object.
        */
        foreach (Student s in students)
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("ID     : " + s.Id);
            Console.WriteLine("Name   : " + s.Name);
            Console.WriteLine("Marks  : " + s.Marks);
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
            /*
                COMPARISON USING IF CONDITION
            */
            if (s.Id == searchId)
            {
                Console.WriteLine("\nStudent Found!");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("ID     : " + s.Id);
                Console.WriteLine("Name   : " + s.Name);
                Console.WriteLine("Marks  : " + s.Marks);

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
            Used because removing items during foreach
            can cause errors.
        */
        for (int i = 0; i < students.Count; i++)
        {
            if (students[i].Id == deleteId)
            {
                /*
                    RemoveAt(i):
                    Removes object from list.
                */
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
            Used to write data into file.
        */
        StreamWriter writer = new StreamWriter(filePath);

        foreach (Student s in students)
        {
            /*
                SAVING FORMAT:
                ID,Name,Marks
            */
            writer.WriteLine(s.Id + "," + s.Name + "," + s.Marks);
        }

        /*
            CLOSE FILE
        */
        writer.Close();

        Console.WriteLine("\nData Saved To File Successfully!");
    }

    /*
        METHOD TO LOAD DATA FROM FILE
    */
    static void LoadFromFile()
    {
        /*
            File.Exists():
            Checks whether file exists or not.
        */
        if (File.Exists(filePath))
        {
            /*
                ReadAllLines():
                Reads all file lines into array.
            */
            string[] lines = File.ReadAllLines(filePath);

            /*
                LOOP THROUGH EACH LINE
            */
            foreach (string line in lines)
            {
                /*
                    SPLIT():
                    Splits text using comma.

                    Example:
                    101,Rahul,89
                */
                string[] data = line.Split(',');

                /*
                    CREATE NEW OBJECT
                */
                Student s = new Student();

                s.Id = Convert.ToInt32(data[0]);
                s.Name = data[1];
                s.Marks = Convert.ToInt32(data[2]);

                students.Add(s);
            }

            Console.WriteLine("\nPrevious Data Loaded Successfully!");
        }
    }
}