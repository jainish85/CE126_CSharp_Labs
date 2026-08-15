using System;

abstract class person
{
    public String PName { get; set; }
    public int age { get; set; }

    public abstract void displayinfo();
}

class Teacher : person
{
    public String Subject { get; set; }
    public double Salary { get; set; }

    public override void displayinfo()
    {
        Console.WriteLine("properties Name: " + PName);
        Console.WriteLine("age: " + age);
        Console.WriteLine("Subject: " + Subject);
        Console.WriteLine("Salary: " + Salary);
    }
}

class program3
{
    static void main(string[] args)
    {

        Teacher t = new Teacher();

        t.PName = "abc";
        t.age = 20;
        t.Subject = " WAD";
        t.Salary = 80000.85;

        t.displayinfo();
    }
}
