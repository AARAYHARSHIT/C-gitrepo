interface IStudentRepository
{
    void AddStudent(string name);
}

class StudentRepository
    : IStudentRepository
{
    public void AddStudent(string name)
    {
        Console.WriteLine(
            $"Student Added: {name}"
        );
    }
}