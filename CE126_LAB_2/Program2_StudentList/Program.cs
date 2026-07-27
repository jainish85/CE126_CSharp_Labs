using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> students = new List<string>();
        int choice;

        do
        {
            Console.WriteLine("\n--- Student Management ---");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Display Students");
            Console.WriteLine("3. Search Student");
            Console.WriteLine("4. Update Student");
            Console.WriteLine("5. Delete Student");
            Console.WriteLine("6. Exit");
            Console.Write("Enter choice: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter name: ");
                    students.Add(Console.ReadLine());
                    break;

                case 2:
                    Console.WriteLine("Student List:");
                    foreach (string s in students)
                        Console.WriteLine(s);
                    break;

                case 3:
                    Console.Write("Enter name to search: ");
                    string search = Console.ReadLine();
                    if (students.Contains(search))
                        Console.WriteLine("Found!");
                    else
                        Console.WriteLine("Not Found!");
                    break;

                case 4:
                    Console.Write("Enter name to update: ");
                    string oldName = Console.ReadLine();
                    int index = students.IndexOf(oldName);
                    if (index != -1)
                    {
                        Console.Write("Enter new name: ");
                        students[index] = Console.ReadLine();
                    }
                    else
                        Console.WriteLine("Student not found!");
                    break;

                case 5:
                    Console.Write("Enter name to delete: ");
                    students.Remove(Console.ReadLine());
                    break;
            }

        } while (choice != 6);

        Console.WriteLine("Program Ended. Press Enter to exit...");
        Console.ReadLine();
    }
}