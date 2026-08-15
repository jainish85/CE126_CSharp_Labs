using System;
class Student
{
    public string Name;
    public int RollNumber;
    public string Course;

    public void Display()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Roll Number: " + RollNumber);
        Console.WriteLine("Course: " + Course);
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        Student s1 = new Student();
        s1.Name = "Yash";
        s1.RollNumber = 134;
        s1.Course = "Computer Engineering";

        Student s2 = new Student();
        s2.Name = "Rahul";
        s2.RollNumber = 126;
        s2.Course = "Information Technology";

        s1.Display();
        s2.Display();
    }
}
