/*
1. A college wants to analyze student records using LINQ. Create a C# console application that stores details of students in a List<Student>. 
   Each student record should contain the following information: 
   Student ID,Name,Department, Semester, Age, CGPA. Add at least to the collection. 

   Write LINQ queries to perform the following operations:

      Display the names of students whose CGPA is greater than 8.0.  
      Display all students belonging to the Computer Engineering department, sorted by CGPA in descending order.  
      Display the top three students based on CGPA.  
      Count the number of students in each department and display the result.
 */


using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public int StuId { get; set; }
    public string StuName { get; set; }
    public string Dept { get; set; }
    public int Sem { get; set; }
    public int Age { get; set; }
    public double CGPA { get; set; }
}

class Student_Record
{
    static void Main(string[] args)
    {
        List<Student> students = new List<Student>()
        {
            new Student{StuId=1, StuName="Alice", Dept="CE", Sem=5, Age=20, CGPA=8.5},
            new Student{StuId=2, StuName="Jack",  Dept="CE", Sem=5, Age=19, CGPA=7.9},
            new Student{StuId=3, StuName="Bob",   Dept="CE", Sem=5, Age=21, CGPA=8.3},
            new Student{StuId=4, StuName="Shive", Dept="CE", Sem=5, Age=19, CGPA=8.0},
            new Student{StuId=5, StuName="dev",   Dept="IT", Sem=5, Age=20, CGPA=7.8},

        };

        var result1 = from s in students
                      where s.CGPA > 8.0
                      select s.StuName;

        Console.WriteLine("Students with CGPA > 8.0");
        foreach (var name in result1)
        {
            Console.WriteLine(name);
        }
        Console.WriteLine();



        var result2 = from s in students
                      where s.Dept == "CE"
                      orderby s.CGPA descending
                      select s;

        Console.WriteLine("Computer Engineering Students (Sorted by CGPA)");
        foreach (var s in result2)
        {
            Console.WriteLine($"{s.StuId} {s.StuName} {s.Dept} {s.CGPA}");
        }
        Console.WriteLine();



        var result3 = students
                        .OrderByDescending(s => s.CGPA)
                        .Take(3);

        Console.WriteLine("Top 3 Students based on CGPA");
        foreach (var s in result3)
        {
            Console.WriteLine($"{s.StuName} - {s.CGPA}");
        }
        Console.WriteLine();




        var result4 = students
                   .GroupBy(s => s.Dept)
                   .Select(g => new
                   {
                       Department = g.Key,
                       Count = g.Count()
                   });
        Console.WriteLine("Student Count by Department");

        foreach (var item in result4)
        {
            Console.WriteLine($"{item.Department} : {item.Count}");
        }
        Console.WriteLine();
        Console.ReadKey();
    }
}
