
using System;
class Student
{
    private string Name;
    private int RollNumber;
    private string Course;

    public string name
    {
        get { return Name; }
        set { Name = value; }
    }

    public int rollNumber
    {
        get { return RollNumber; }
        set
        {
            if (value > 0)
                RollNumber = value;
            else
                Console.WriteLine("Roll Number must be positive.");
        }
    }

    public string course
    {
        get { return Course; }
        set { Course = value; }
    }

    public void Display()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Roll Number: " + RollNumber);
        Console.WriteLine("Course: " + Course);
    }
}

class Program
{
    static void Main()
    {
        Student s = new Student();

        s.name = "Dev";
        s.rollNumber = 139;
        s.course = "Computer Engineering";

        s.Display();
    }
}

